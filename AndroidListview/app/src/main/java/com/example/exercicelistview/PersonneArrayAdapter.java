package com.example.exercicelistview;

import android.content.Context;
import android.net.Uri;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.annotation.NonNull;

import com.example.exercicelistview.Personne;
import com.example.exercicelistview.R;

import java.util.List;

public class PersonneArrayAdapter extends ArrayAdapter<Personne> {
    private List<Personne> listPersonne;
    public PersonneArrayAdapter(Context _context, List<Personne> _personnes){
        super(_context, R.layout.list_item, _personnes);
        listPersonne = _personnes;
    }

    @NonNull
    @Override
    public View getView(int _i, View _view, @NonNull ViewGroup _viewGroup){
    View result = _view;
    if (result == null){
        LayoutInflater inflater = (LayoutInflater) getContext().getSystemService(Context.LAYOUT_INFLATER_SERVICE);
        result = inflater.inflate(R.layout.list_item, null);
    }
    Personne personneOfItem = (Personne) getListPersonnes().get(_i);
    if(personneOfItem != null){
        TextView nomTextView = (TextView) result.findViewById(R.id.textNom);
        TextView prenomTextView = (TextView) result.findViewById(R.id.textPrenom);
        ImageView avatarImageView = (ImageView) result.findViewById(R.id.imageView);

        if(nomTextView != null){
            nomTextView.setText("Nom: " + personneOfItem.getNom());
        }
        if(prenomTextView != null){
            prenomTextView.setText("Prenom: " + personneOfItem.getPrenom());
        }
        if(avatarImageView != null){
            avatarImageView.setImageResource(personneOfItem.getImgSrc());
        }
    }

    return result;
    }

    public List<Personne> getListPersonnes(){
        return this.listPersonne;
    }
}
