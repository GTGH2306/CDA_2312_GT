package com.example.apptutojava;

import android.view.View;
import android.widget.TextView;

public class OnClickDecListener implements View.OnClickListener {
    TextView textView;
    public OnClickDecListener(TextView _textView){
        this.textView = _textView;
    }
    @Override
    public void onClick(View v) {
        int value = Integer.parseInt(textView.getText().toString());
        textView.setText(Integer.toString(value - 1));
    }
}
