package com.example.exercicelistview;

public class Personne {
    private String nom;
    private String prenom;
    private int imgSrc;

    public Personne(String _nom, String _prenom, int _imgSrc){
        this.nom = _nom;
        this.prenom = _prenom;
        this.imgSrc = _imgSrc;
    }
    public Personne(Personne _personToCopy){
        this(_personToCopy.getNom(), _personToCopy.getPrenom(), _personToCopy.getImgSrc());
    }

    public String getNom(){
        return this.nom;
    }
    public String getPrenom(){
        return this.prenom;
    }
    public int getImgSrc(){
        return this.imgSrc;
    }
}
