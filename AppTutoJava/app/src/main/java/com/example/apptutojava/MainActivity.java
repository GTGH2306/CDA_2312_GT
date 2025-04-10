package com.example.apptutojava;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        Button inc = (Button) findViewById(R.id.buttonInc);
        Button dec = (Button) findViewById(R.id.buttonDec);
        Button quit = (Button) findViewById(R.id.buttonQuit);
        TextView counter = (TextView) findViewById(R.id.textCounter);


        inc.setOnClickListener(v -> {
            int value = Integer.parseInt(counter.getText().toString());
            counter.setText(Integer.toString(value + 1));
        });

        dec.setOnClickListener(new OnClickDecListener(counter));

        quit.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                /*
                Intent ActivityForExiting = new Intent(getApplicationContext(), MainActivity.class);
                ActivityForExiting.setFlags(Intent.FLAG_ACTIVITY_CLEAR_TOP);
                ActivityForExiting.putExtra("EXIT", true);
                startActivity(ActivityForExiting);
                */
                finish();
                System.exit(0);
            }
        });
    }
}