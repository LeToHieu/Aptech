package nguyenvana.aprotrain.com;

import androidx.appcompat.app.AppCompatActivity;

import android.database.Cursor;
import android.graphics.Color;
import android.os.Bundle;
import android.widget.ListView;

import java.util.ArrayList;
import java.util.Date;

import nguyenvana.aprotrain.com.adapters.CustomAdapter;
import nguyenvana.aprotrain.com.database.NoteModify;
import nguyenvana.aprotrain.com.models.Note;

public class MainActivity extends AppCompatActivity {
    private ListView listViewNote;
    //mock, fake data
    private ArrayList<Note> notes = new ArrayList<Note>();
    private CustomAdapter customAdapter;
    private NoteModify noteModify;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.main_activity);
        listViewNote = findViewById(R.id.listViewNote);
        noteModify = new NoteModify(this);
        //data => adapter
        //noteModify.insertNote(new Note("Di choi", true, new Date()));

        Cursor cursor = noteModify.getNotesCursor();
        customAdapter = new CustomAdapter(this, cursor, true);
        listViewNote.setAdapter(customAdapter);
        listViewNote.setBackgroundColor(Color.WHITE);
    }
}