package com.example.exercicelistview;

import android.os.Bundle;
import android.widget.EditText;

import androidx.appcompat.app.AppCompatActivity;

public class NewPersonActivity extends AppCompatActivity {
    @Override
    protected void onCreate(Bundle savedInstanceState){
        super.onCreate(savedInstanceState);
        setContentView(R.layout.new_person);

        findViewById(R.id.buttonValidatePerson).setOnClickListener(v -> {
            EditText fieldLastName = findViewById(R.id.fieldLastName);
            String lastName = fieldLastName.getText().toString();
            EditText fieldFirstName = findViewById(R.id.fieldFirstName);
            String firstName = fieldFirstName.getText().toString();

            if(lastName.length() > 0 && firstName.length() > 0){
                this.getIntent().putExtra("firstName", firstName);
                this.getIntent().putExtra("lastName", lastName);

                this.setResult(RESULT_OK, this.getIntent());
            }
            finish();
        });
    }

}
