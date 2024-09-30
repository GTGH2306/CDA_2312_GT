using CLObjet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFControlLibrary;
using static CLObjet.Production;

namespace WFToutEmballe
{
    public partial class FormProduction : Form
    {
        private static readonly int multiplier = 1000;

        private readonly Dictionary<char, Production> productions = new Dictionary<char, Production>()
        {
            { 'A', new Production(1000 * multiplier, 2, 10000) },
            { 'B', new Production(5000 * multiplier, 1, 25000) },
            { 'C', new Production(10000 * multiplier, 15, 120000) },
            //{ 'D', new Production(100 * multiplier, 9, 1500 ) }
        };
        public FormProduction()
        {
            InitializeComponent();
            foreach (KeyValuePair<char, Production> _production in productions.Reverse())
            {
                AddProgressBar(_production);
            }
            foreach (KeyValuePair<char, Production> _production in productions)
            {
                AddTabPage(_production);
                AddMenuItems(_production);
                AddStatusStrip(_production);
                AddRefreshEvents(_production.Value);
                AddTrafficButtons(_production);
            }

            ToolStripStatusLabel labelHour = new ToolStripStatusLabel();
            labelHour.Name = "toolStripLabelHour";
            labelHour.Text = DateTime.Now.ToString("T");
            this.statusStrip.Items.Add(labelHour);

            this.FormClosed += new FormClosedEventHandler(delegate
            {
                foreach (KeyValuePair<char, Production> _prod in productions)
                {
                    _prod.Value.GetThread().Abort();
                }
            });
            
        }

        //Ajouteurs d'éléments initiaux
        private void AddProgressBar(KeyValuePair<char, Production> _production)
        {
            //Add progress bar to panel
            ProductionProgressBar progressBarProd = new ProductionProgressBar(_production.Key, _production.Value);
            progressBarProd.Name = "progressBarProd" + _production.Key;
            progressBarProd.Dock = DockStyle.Top;
            this.panelProgressBar.Controls.Add(progressBarProd);
        }
        private void AddTabPage(KeyValuePair<char, Production> _production)
        {
            //Add tabPage to TabPanel
            TabPage tabPageProd = new TabPage();
            tabPageProd.BackColor = SystemColors.Window;
            tabPageProd.Text = "Type " + _production.Key;
            tabPageProd.Name = "tabPageProd" + _production.Key;
            ProductionTabPage tabPageContent = new ProductionTabPage(_production.Key, _production.Value);
            tabPageProd.Controls.Add(tabPageContent);
            this.tabControlProd.Controls.Add(tabPageProd);
        }
        private void AddMenuItems(KeyValuePair<char, Production> _production)
        {
            ToolStripMenuItem prodStart = new ToolStripMenuItem();
            prodStart.Tag = this.productions[_production.Key];
            prodStart.Name = "toolStripMenuItemStart" + _production.Key;
            prodStart.Text = _production.Key.ToString();
            prodStart.Click += new EventHandler(StartProduction_OnClick);
            this.startToolStripMenuItem.DropDownItems.Add(prodStart);

            ToolStripMenuItem prodPause = new ToolStripMenuItem();
            prodPause.Tag = this.productions[_production.Key];
            prodPause.Name = "toolStripMenuItemPause" + _production.Key;
            prodPause.Text = _production.Key.ToString();
            prodPause.Enabled = false;
            prodPause.Click += new EventHandler(PauseProduction_OnClick);
            this.suspendToolStripMenuItem.DropDownItems.Add(prodPause);

            ToolStripMenuItem prodContinue = new ToolStripMenuItem();
            prodContinue.Tag = this.productions[_production.Key];
            prodContinue.Name = "toolStripMenuItemContinue" + _production.Key;
            prodContinue.Text = _production.Key.ToString();
            prodContinue.Enabled = false;
            prodContinue.Click += new EventHandler(ResumeProduction_OnClick);
            this.continueToolStripMenuItem.DropDownItems.Add(prodContinue);

            ToolStripMenuItem prodReset = new ToolStripMenuItem();
            prodReset.Tag = this.productions[_production.Key];
            prodReset.Name = "toolStripMenuItemReset" + _production.Key;
            prodReset.Text = _production.Key.ToString();
            prodReset.Enabled = false;
            prodReset.Click += new EventHandler(ResetProduction_OnClick);
            this.resetToolStripMenuItem.DropDownItems.Add(prodReset);
        }
        private void AddStatusStrip(KeyValuePair<char, Production> _production)
        {
            ToolStripStatusLabel label = new ToolStripStatusLabel();
            label.Name = "toolStripStatusLabelProd" + _production.Key;
            label.Tag = _production.Value;
            label.Margin = new Padding(0, 3, 50, 2);
            this.statusStrip.Items.Add(label);
            RefreshStatusStrip(_production.Value);
        }
        private void AddTrafficButtons(KeyValuePair<char, Production> _production)
        {
            UCTrafficLightButtons buttons = new UCTrafficLightButtons(_production);
            buttons.UCTrafficLightButtonClicked += new UCTrafficLightButtons.UCTrafficLightButtonClickedEventHandler(TrafficButtons_OnClick);
            this.flowLayoutPanelTraffics.Controls.Add(buttons);
        }

        //Event on menu click
        private void StartProduction_OnClick(object _sender, EventArgs _e)
        {
            ToolStripMenuItem sender = (ToolStripMenuItem)_sender;
            Production senderProd = (Production)sender.Tag;
            senderProd.Start();
        }
        private void PauseProduction_OnClick(object _sender, EventArgs _e)
        {
            ToolStripMenuItem sender = (ToolStripMenuItem)_sender;
            Production senderProd = (Production)sender.Tag;
            senderProd.Suspend();
        }
        private void ResumeProduction_OnClick(object _sender, EventArgs _e)
        {
            ToolStripMenuItem sender = (ToolStripMenuItem)_sender;
            Production senderProd = (Production)sender.Tag;
            senderProd.Resume();
        }
        private void ResetProduction_OnClick(object _sender, EventArgs _e)
        {
            ToolStripMenuItem sender = (ToolStripMenuItem)_sender;
            Production senderProd = (Production)sender.Tag;
            ResetProduction(senderProd);
        }
        
        //Event on TrafficButtonsClick
        private void TrafficButtons_OnClick(UCTrafficLightButtons _sender, Color _clr)
        {
            Production prod = (Production)_sender.Tag;

            if (_clr == Color.Green)
            {
                if (prod.GetProductionState() == ProductionStates.Initialized)
                {
                    prod.Start();
                } else
                {
                    ResetProduction(prod);
                }
            } else if (_clr == Color.Yellow)
            {
                prod.Resume();
            } else if (_clr == Color.Red)
            {
                prod.Suspend();
            }
        }
        private void ResetProduction(Production _production)
        {
            char key = GetKeyFromProduction(_production);

            _production.GetThread().Abort();

            this.productions[key] = new Production(_production);
            foreach (ToolStripMenuItem _item in GetToolStripMenuItems(_production))
            {
                _item.Tag = this.productions[key];
            }
            foreach (ToolStripStatusLabel _label in this.statusStrip.Items)
            {
                if (_label.Tag == _production)
                {
                    _label.Tag = this.productions[key];
                }
            }
            GetProductionProgressBar(_production).Tag = this.productions[key];
            GetProductionTabPage(_production).Tag = this.productions[key];
            GetTrafficButtons(_production).Tag = this.productions[key];
            AddRefreshEvents(this.productions[key]);

            RefreshMenuItem_OnStateChange(this.productions[key]);
            RefreshProgressBar(this.productions[key]);
            RefreshTabPage(this.productions[key]);
            RefreshStatusStrip(this.productions[key]);
            RefreshTrafficButtons(this.productions[key]);
        }

        //Rafrachisseurs de vue
        private void RefreshMenuItem_OnStateChange(Production _sender)
        {
            ToolStripMenuItem startButton = null;
            ToolStripMenuItem pauseButton= null;
            ToolStripMenuItem resumeButton = null;
            ToolStripMenuItem resetButton = null;
            foreach (ToolStripMenuItem _Button in this.startToolStripMenuItem.DropDownItems)
            {
                if (_Button.Tag == _sender)
                {
                    startButton = _Button;
                }
            }
            foreach (ToolStripMenuItem _Button in this.suspendToolStripMenuItem.DropDownItems)
            {
                if (_Button.Tag == _sender)
                {
                    pauseButton = _Button;
                }
            }
            foreach (ToolStripMenuItem _Button in this.continueToolStripMenuItem.DropDownItems)
            {
                if (_Button.Tag == _sender)
                {
                    resumeButton = _Button;
                }
            }
            foreach (ToolStripMenuItem _Button in this.resetToolStripMenuItem.DropDownItems)
            {
                if (_Button.Tag == _sender)
                {
                    resetButton = _Button;
                }
            }

            if (startButton != null &&
                pauseButton != null &&
                resumeButton != null &&
                resetButton != null &&
                this.IsHandleCreated)
            {
                try
                {
                    switch (_sender.GetProductionState())
                    {

                        case ProductionStates.Initialized:
                            this.BeginInvoke(new MethodInvoker(delegate ()
                            {
                                startButton.Enabled = true;
                                pauseButton.Enabled = false;
                                resumeButton.Enabled = false;
                                resetButton.Enabled = false;
                            }));
                            break;
                        case ProductionStates.OnGoing:
                            this.BeginInvoke(new MethodInvoker(delegate ()
                            {
                                startButton.Enabled = false;
                                pauseButton.Enabled = true;
                                resumeButton.Enabled = false;
                                resetButton.Enabled = true;
                            }));
                            break;
                        case ProductionStates.Suspended:
                            this.BeginInvoke(new MethodInvoker(delegate ()
                            {
                                startButton.Enabled = false;
                                pauseButton.Enabled = false;
                                resumeButton.Enabled = true;
                                resetButton.Enabled = true;
                            }));
                            break;
                        case ProductionStates.Finished:
                            this.BeginInvoke(new MethodInvoker(delegate ()
                            {
                                startButton.Enabled = false;
                                pauseButton.Enabled = false;
                                resumeButton.Enabled = false;
                                resetButton.Enabled = true;
                            }));
                            break;
                    }
                }
                catch (InvalidAsynchronousStateException _e) { }
            }
        }
        private void RefreshProgressBar(Production _sender)
        {
            if (_sender.GetNbOfCrates() % GetNbOfCratesToRefreshView(_sender) == 0
                || _sender.GetProductionState() != ProductionStates.OnGoing)
            {
                ProductionProgressBar prodProgBar = GetProductionProgressBar(_sender);
                try
                { 
                    prodProgBar?.Invoke(new MethodInvoker(delegate
                    {
                        prodProgBar.ProgressValue = Production.GetValidCratesNb(_sender.GetCratesProduced());
                    }));
                }
                catch (InvalidAsynchronousStateException _e)
                {

                }
            }
        }
        private void RefreshTabPage(Production _sender)
        {
            if (_sender.GetNbOfCrates() % GetNbOfCratesToRefreshView(_sender) == 0
                || _sender.GetProductionState() != ProductionStates.OnGoing)
            {
                try {
                    ProductionTabPage productionTabPage = GetProductionTabPage(_sender);
                    productionTabPage?.Invoke(new MethodInvoker(delegate
                    {
                        productionTabPage.TextNbCrates = _sender.GetNbOfCrates().ToString();
                        productionTabPage.TextFlawedOverall = Math.Round(_sender.GetFlawedCrateSinceBeginningRate(), 2).ToString() + "%";
                        productionTabPage.TextFlawedLastHour = Math.Round(_sender.GetFlawedCrateOfLastHourPercent(), 2).ToString() + "%";
                    }));
                }
                catch (InvalidAsynchronousStateException _e)
                {

                }
            }
        }
        private void RefreshStatusStrip(Production _sender)
        {
            try
            {
                foreach (ToolStripStatusLabel _label in statusStrip.Items)
                {
                    if (_label.Tag == _sender)
                    {
                        _label.Text = "Caisses " + GetKeyFromProduction(_sender) + ": ";
                        switch (_sender.GetProductionState())
                        {
                            case ProductionStates.OnGoing:
                                _label.Text += "En cours";
                                break;
                            case ProductionStates.Suspended:
                                _label.Text += "Suspendu";
                                break;
                            case ProductionStates.Initialized:
                                _label.Text += "Initialisé";
                                break;
                            case ProductionStates.Finished:
                                _label.Text += "Terminé";
                                break;
                        }
                    }
                }
            } catch (InvalidAsynchronousStateException _e){}
            
        }
        private void RefreshTrafficButtons(Production _sender)
        {
            UCTrafficLightButtons buttons = GetTrafficButtons(_sender);
            if (buttons != null && this.IsHandleCreated)
            {
                try
                {
                    buttons?.Invoke(new MethodInvoker(delegate
                    {
                        switch (_sender.GetProductionState())
                        {
                            case ProductionStates.Initialized:
                                buttons.GreenEnabled = true;
                                buttons.YellowEnabled = false;
                                buttons.RedEnabled = false;
                                break;
                            case ProductionStates.Suspended:
                                buttons.GreenEnabled = true;
                                buttons.YellowEnabled = true;
                                buttons.RedEnabled = false;
                                break;
                            case ProductionStates.OnGoing:
                                buttons.GreenEnabled = true;
                                buttons.YellowEnabled = false;
                                buttons.RedEnabled = true;
                                break;
                            case ProductionStates.Finished:
                                buttons.GreenEnabled = true;
                                buttons.YellowEnabled = false;
                                buttons.RedEnabled = false;
                                break;
                        }
                    }));
                }
                catch (InvalidAsynchronousStateException _e) { }
            }
        }


        //Methodes
        private char GetKeyFromProduction(Production _production)
        {
            return productions.FirstOrDefault(p => p.Value == _production).Key;
        }
        private List<ToolStripMenuItem> GetToolStripMenuItems(Production _production)
        {
            List<ToolStripMenuItem> results = new List<ToolStripMenuItem>();
            foreach (ToolStripMenuItem _Button in this.startToolStripMenuItem.DropDownItems)
            {
                if (_Button.Tag == _production)
                {
                    results.Add(_Button);
                }
            }
            foreach (ToolStripMenuItem _Button in this.suspendToolStripMenuItem.DropDownItems)
            {
                if (_Button.Tag == _production)
                {
                    results.Add(_Button);
                }
            }
            foreach (ToolStripMenuItem _Button in this.continueToolStripMenuItem.DropDownItems)
            {
                if (_Button.Tag == _production)
                {
                    results.Add(_Button);
                }
            }
            foreach (ToolStripMenuItem _Button in this.resetToolStripMenuItem.DropDownItems)
            {
                if (_Button.Tag == _production)
                {
                    results.Add(_Button);
                }
            }
            return results;
        }

        private ProductionProgressBar GetProductionProgressBar(Production _production)
        {
            ProductionProgressBar result = null;
            foreach (ProductionProgressBar _bar in this.panelProgressBar.Controls)
            {
                if(_bar.Tag == _production)
                {
                    result = _bar;
                }
            }
            return result;
        }
        private ProductionTabPage GetProductionTabPage(Production _production)
        {
            ProductionTabPage result = null;
            foreach(TabPage _tabPage in this.tabControlProd.TabPages)
            {
                ProductionTabPage productionTabPage = _tabPage.Controls.Count > 0? (ProductionTabPage)_tabPage.Controls[0] : null;
                if (productionTabPage != null && productionTabPage.Tag == _production)
                {
                    result = productionTabPage;
                }
            }
            return result;
        }
        private UCTrafficLightButtons GetTrafficButtons(Production _production)
        {
            UCTrafficLightButtons result = null;
            foreach (UCTrafficLightButtons _tButtons in this.flowLayoutPanelTraffics.Controls)
            {
                if (_tButtons.Tag == _production)
                {
                    result = _tButtons;
                }
            }
            return result;
        }
        private int GetNbOfCratesToRefreshView(Production _production)
        {
            return (int)Math.Ceiling(_production.GetCratesPerHour() * 0.0000011d);
        }
        private void AddRefreshEvents(Production _production)
        {
            _production.ProductionStateChange += new ProductionStateChangeHandler(RefreshMenuItem_OnStateChange);
            _production.ProductionStateChange += new ProductionStateChangeHandler(RefreshProgressBar);
            _production.ProductionStateChange += new ProductionStateChangeHandler(RefreshTabPage);
            _production.ProductionStateChange += new ProductionStateChangeHandler(RefreshStatusStrip);
            _production.ProductionStateChange += new ProductionStateChangeHandler(RefreshTrafficButtons);
            _production.ProductionProducedCrates += new ProductionProducedCratesHandler(RefreshProgressBar);
            _production.ProductionProducedCrates += new ProductionProducedCratesHandler(RefreshTabPage);
            this.HandleCreated += new EventHandler(delegate
            {
                RefreshTrafficButtons(_production);
            });
        }

        //Timer pour l'horloge
        private void timer_Tick(object sender, EventArgs e)
        {
            foreach (ToolStripStatusLabel _label in this.statusStrip.Items)
            {
                if (_label.Name == "toolStripLabelHour")
                {
                    _label.Text = DateTime.Now.ToString("T");
                }
            }
        }
    }
}
