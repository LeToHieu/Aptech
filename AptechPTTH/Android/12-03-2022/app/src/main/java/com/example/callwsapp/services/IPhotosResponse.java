package com.example.callwsapp.services;

import com.example.callwsapp.models.Photo;

import java.util.ArrayList;

public interface IPhotosResponse {
    public void getPhotosResponse(ArrayList<Photo> photos, String error);
    public void sayHello(String content);//PhotoService say hello "PhotoListActivity"
}
