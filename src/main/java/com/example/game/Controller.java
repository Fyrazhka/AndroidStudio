package com.example.game;

import javafx.fxml.FXML;
import javafx.scene.control.Button;
import javafx.scene.control.Label;

public class Controller {
    public Button bStart;
    @FXML
    private Label name_of_game;

    @FXML
    protected void onBStartClick() {
        name_of_game.setText("Погнали");

    }
}