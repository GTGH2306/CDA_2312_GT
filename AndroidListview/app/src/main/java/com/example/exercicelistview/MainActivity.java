package com.example.exercicelistview;

import android.content.Intent;
import android.net.Uri;
import android.os.Bundle;
import android.view.ContextMenu;
import android.view.MenuInflater;
import android.view.MenuItem;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ListView;

import androidx.activity.result.ActivityResult;
import androidx.activity.result.ActivityResultCallback;
import androidx.activity.result.ActivityResultLauncher;
import androidx.activity.result.contract.ActivityResultContracts;
import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import java.util.ArrayList;

public class MainActivity extends AppCompatActivity {
    private PersonneArrayAdapter arrayAdp;
    private ListView listView;
    private ActivityResultLauncher<Intent> resultLauncher = registerForActivityResult(
            new ActivityResultContracts.StartActivityForResult(), //façon de lancer l'intent en voulant un retour
            new ActivityResultCallback<ActivityResult>() {
                @Override
                public void onActivityResult(ActivityResult _activityResult) { //code déclenché au résultat de l'activité
                    Intent resultIntent = _activityResult.getData();
                    if (_activityResult.getResultCode() == RESULT_OK){
                        arrayAdp.getListPersonnes().add(
                                new Personne(
                                        resultIntent.getStringExtra("lastName"),
                                        resultIntent.getStringExtra("firstName"),
                                        R.drawable.pti_bonhomme
                                ));
                        listView.setAdapter(arrayAdp);
                    }
                }
            }
    );

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        listView = findViewById(R.id.listView);

        this.arrayAdp = new PersonneArrayAdapter(this, new ArrayList<>());
        this.arrayAdp.getListPersonnes().add(new Personne("nom1", "prenom1", R.drawable.important));
        this.arrayAdp.getListPersonnes().add(new Personne("nom2", "prenom2", R.drawable.pti_bonhomme));
        this.arrayAdp.getListPersonnes().add(new Personne("nom3", "prenom3", R.drawable.babane));
        listView.setAdapter(arrayAdp);
        registerForContextMenu(listView);

        listView.setOnCreateContextMenuListener((menu, v, menuInfo) -> {
            MainActivity.super.onCreateContextMenu(menu, v, menuInfo);

            MenuInflater inflater = getMenuInflater();
            inflater.inflate(R.menu.menu_listview_personne, menu);
        });

        findViewById(R.id.button).setOnClickListener(v -> {
            Intent intentNewPerson = new Intent(this, NewPersonActivity.class);
            resultLauncher.launch(intentNewPerson);
        });
    }

        // GetContent creates an ActivityResultLauncher<String> to let you pass
    // in the mime type you want to let the user select


    @Override
    public boolean onContextItemSelected(@NonNull MenuItem _item){
        AdapterView.AdapterContextMenuInfo menuInfo = (AdapterView.AdapterContextMenuInfo) _item.getMenuInfo();
        int pos;
        if (menuInfo == null){
            return false;
        } else {
            pos = menuInfo.position;
        }

        if (_item.getItemId() == R.id.copy_person){
            Personne personToCopy = this.arrayAdp.getListPersonnes().get(pos);
            this.arrayAdp.getListPersonnes().add(new Personne(personToCopy));
        } else if (_item.getItemId() == R.id.del_person) {
            this.arrayAdp.getListPersonnes().remove(pos);
        } else {
            return false;
        }
        ListView listView = findViewById(R.id.listView);
        listView.setAdapter(arrayAdp);
        return true;
    }
}