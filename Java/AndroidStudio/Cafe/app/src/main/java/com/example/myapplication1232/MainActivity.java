package com.example.myapplication1232;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.CheckBox;
import android.widget.EditText;
import android.widget.TextView;

import com.google.android.material.snackbar.Snackbar;

import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        getSupportActionBar().hide();
        setContentView(R.layout.activity_main);
        //автоматически вводится почта,если до этого она была уже введена
        loadText();
    }
    //что будет происходить при возобновлении приложения
    protected void onResume(Bundle savedInstanceState){
        getSupportActionBar().hide();
    }

    public boolean isFileEmpty(File file) {
        return file.length() == 0;
    }

    //реализация ф-ии автоматического ввода почты
    public void loadText() {
        EditText textBox = findViewById(R.id.text_emailAddress);
        String[] textArray;
        textArray = new String[2];
        //открывыем файловый поток
        FileInputStream fin = null;
        try {
            //открываем файл для чтения
            fin = openFileInput("email");
            File file=new File("/email");

            if((isFileEmpty(file))) {
                //побайтовое считывание из файла
                byte[] bytes = new byte[fin.available()];
                fin.read(bytes);
                String text = new String(bytes);

                if (text.equals("0")) {
                    textBox = findViewById(R.id.text_emailAddress);
                    textBox.setText(" ", TextView.BufferType.EDITABLE);
                }
                else {
                textBox = findViewById(R.id.text_emailAddress);
                textBox.setText(text, TextView.BufferType.EDITABLE);
                }

                fin.close();
            }
            else{
                //если почта до этого не была введена оставляем пустое поле
                textBox = findViewById(R.id.text_emailAddress);
                textBox.setText("", TextView.BufferType.EDITABLE);
            }

        }
        catch(IOException ex) {
        }

    }
    //реализация ф-ии сохранения почты
    public void saveText(View view,boolean b) {
        //открывыем файловый поток
        FileOutputStream fout = null;
        try {
            //открываем файл для записи(создаем указатель на файл)
            fout = openFileOutput("email",MODE_PRIVATE);
            if(b) {
                EditText textBox = findViewById(R.id.text_emailAddress);
                String text = textBox.getText().toString();
                fout.write(text.getBytes());
            }
            else
                fout.write("0".getBytes());

        } catch (IOException ex) {
            Snackbar mSnackbar = Snackbar.make(view, ex.getMessage(), Snackbar.LENGTH_SHORT).setAction("Action", null);
            SnackbarSHOW(mSnackbar);

        } finally {
            try {
                if (fout != null) {
                    fout.close();
                }
            } catch (IOException ex) {
                Snackbar mSnackbar = Snackbar.make(view, ex.getMessage(), Snackbar.LENGTH_SHORT).setAction("Action", null);
                SnackbarSHOW(mSnackbar);
            }
        }
    }

    //Центрирование текста и его отображения
    public void SnackbarSHOW(Snackbar mSnackbar){
        View mView = mSnackbar.getView();
        TextView mTextView = (TextView) mView.findViewById(R.id.snackbar_text);
        mTextView.setTextAlignment(View.TEXT_ALIGNMENT_CENTER);
        mSnackbar.setTextColor(0XFF000000);
        mSnackbar.setBackgroundTint(0XFFFFFFFF);

        mSnackbar.show();
    }

    //ф-ия нажатия на кнопку входа в самом начале
    public void onloginButtonClick(View view){
        Context context=MainActivity.this;

        EditText email=findViewById(R.id.text_emailAddress);
        EditText password = findViewById(R.id.text_password);
        String str="";


        if(email.length()==0) {
            Snackbar mSnackbar = Snackbar.make(view, "Введите email", Snackbar.LENGTH_SHORT).setAction("Action", null);
            SnackbarSHOW(mSnackbar);
        }
        else{
            str=email.getText().toString();
            //проверка на то,содрежит ли почта @
            if(str.contains("@") && str.contains(".") && !str.contains(" ")) {
                password = findViewById(R.id.text_password);

                if (password.length() == 0) {
                    Snackbar mSnackbar = Snackbar.make(view, "Введите пароль", Snackbar.LENGTH_SHORT).setAction("Action", null);
                    SnackbarSHOW(mSnackbar);
                }
                else {
                    str=password.getText().toString();
                    if (!str.contains(" ")) {
                        CheckBox checkBox = (CheckBox)findViewById(R.id.check_login);
                        if(checkBox.isChecked())
                            saveText(view,true);
                        else
                            saveText(view,false);

                        //переход на следующую активность
                        Class cActivity = ChooseActivity.class;
                        Intent chooseActivity = new Intent(context, cActivity);
                        startActivity(chooseActivity);
                    } else {
                        Snackbar mSnackbar = Snackbar.make(view, "Введен некорректный пароль", Snackbar.LENGTH_SHORT).setAction("Action", null);
                        SnackbarSHOW(mSnackbar);
                    }
                }
            }
            else {
                Snackbar mSnackbar = Snackbar.make(view, "Введен некорректный email", Snackbar.LENGTH_SHORT).setAction("Action", null);
                SnackbarSHOW(mSnackbar);
            }
        }
    }
}