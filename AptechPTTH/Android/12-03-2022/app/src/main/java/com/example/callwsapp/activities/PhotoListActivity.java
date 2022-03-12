package com.example.callwsapp.activities;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.util.Log;
import android.widget.ListView;

import com.example.callwsapp.R;
import com.example.callwsapp.adapters.PhotoAdapter;
import com.example.callwsapp.models.Photo;
import com.example.callwsapp.services.IPhotosResponse;
import com.example.callwsapp.services.PhotoService;

import java.util.ArrayList;

public class PhotoListActivity extends AppCompatActivity {
    private ListView listViewPhotos;
    private ArrayList<Photo> photos = new ArrayList<Photo>();
    private PhotoService photoService = new PhotoService();
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.photo_list_activity);
        listViewPhotos = findViewById(R.id.listViewPhotos);
        //Activity call service
        photoService.getAllPhotos(new IPhotosResponse() {
            @Override
            public void getPhotosResponse(ArrayList<Photo> photos, String error) {

            }

            @Override
            public void sayHello(String content) {
                Log.d("aa", "haha");
                //thay vi truyen content, truyen photos sang activity
                listViewPhotos.setAdapter(new PhotoAdapter(photos));
                //truyen du lieu giua 2 object su dung interface
            }
        });
        Log.d("aaa", "aaaaaa");
    }
}