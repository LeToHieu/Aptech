package com.example.myapp;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.widget.Toast;

import com.example.myapp.models.Person;

public class LoginActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.login_activity);
        Integer x = getIntent().getIntExtra("x", 0);
        Integer y = getIntent().getIntExtra("y", 0);
        Person personA = (Person) getIntent().getSerializableExtra("personA");
        //Toast.makeText(this, String.format("x = %d, y = %d", x, y), Toast.LENGTH_LONG).show();
        Toast.makeText(this, String.format("personA's details: %s", personA.toString()), Toast.LENGTH_LONG).show();
        //how to transfer an object
    }
}