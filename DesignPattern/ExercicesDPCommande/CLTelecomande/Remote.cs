using System.Runtime.InteropServices.ObjectiveC;

namespace CLTelecomande
{
    public class Remote
    {
        private Dictionary<int, CommandConfig> commands = new Dictionary<int, CommandConfig>();
        private List<ICommand> history;
        public Remote()
        {
            this.history = new List<ICommand>();
        }
        public void SetCommand(int _btnNb, Type _command, params object[] _parameters)
        {
            CommandConfig command = new CommandConfig()
            {
                CommandType = _command,
                Parameters = _parameters
            };
            
            if (this.commands.ContainsKey(_btnNb))
            {
                this.commands[_btnNb] = command;
            }
            else
            {
                this.commands.Add(_btnNb, command);
            }
        }
        public void ButtonPress(int _btnNb)
        {
            ICommand? command = (ICommand?)Activator.CreateInstance(this.commands[_btnNb].CommandType, this.commands[_btnNb].Parameters);

            if (command != null)
            {

                command.Execute();
                this.history.Add(command);
            }
        }
        public void Reverse()
        {
            if (this.history.Count > 0)
            {
                this.history[this.history.Count - 1].Reverse();
                this.history.RemoveAt(this.history.Count - 1);
            }
        }

        private struct CommandConfig()
        {
            public Type CommandType { get; set; }
            public object[] Parameters { get; set; }
        }

    }
}
