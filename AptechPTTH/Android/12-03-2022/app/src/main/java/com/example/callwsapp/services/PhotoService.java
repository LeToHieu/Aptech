package com.example.callwsapp.services;


import android.util.Log;

import androidx.annotation.NonNull;

import java.io.IOException;

import okhttp3.Call;
import okhttp3.Callback;
import okhttp3.OkHttpClient;
import okhttp3.Request;
import okhttp3.Response;

//CRUD lien quan den Photo
public class PhotoService {
    public static final String urlGetPhotos = "https://jsonplaceholder.typicode.com/photos";
    private OkHttpClient okHttpClient = new OkHttpClient();
    //callback
    public void getAllPhotos(IPhotosResponse iPhotosResponse){
        Request request = new Request.Builder().url(urlGetPhotos).build();
        okHttpClient.newCall(request).enqueue(
                new Callback() {
                    @Override
                    public void onFailure(@NonNull Call call, @NonNull IOException e) {
                        Log.d("dd", "dhahhaa");
                    }

                    @Override
                    public void onResponse(@NonNull Call call, @NonNull Response response) throws IOException {
                        iPhotosResponse.sayHello("Good morning!");
                        Log.d("dd", "kakakaa");
                    }
                }
        );
    }
}
