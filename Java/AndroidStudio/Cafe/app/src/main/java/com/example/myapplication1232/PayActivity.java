package com.example.myapplication1232;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.content.Intent;
import android.os.Bundle;
import android.view.MenuItem;
import android.view.View;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

import com.google.android.material.snackbar.Snackbar;

public class PayActivity extends AppCompatActivity {

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        int id = item.getItemId();
        if ( id == android.R.id.home ) {
            finish();
            return true;
        }
        return super.onOptionsItemSelected(item);
    }

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        getSupportActionBar().hide();
        setContentView(R.layout.pay);
    }

    protected void onResume(Bundle savedInstanceState){
        getSupportActionBar().hide();
    }

    public void SnackbarSHOW(Snackbar mSnackbar){
        View mView = mSnackbar.getView();
        TextView mTextView = (TextView) mView.findViewById(R.id.snackbar_text);
        mTextView.setTextAlignment(View.TEXT_ALIGNMENT_CENTER);
        mSnackbar.setTextColor(0XFF000000);
        mSnackbar.setBackgroundTint(0XFFFFFFFF);
        mSnackbar.show();
    }

    //ф-ия проверки на оплату
    public void card_pay(View view){
        //получаем номер карты
        EditText number_of_card=findViewById(R.id.text_number_of_card);
        EditText cvc = findViewById(R.id.text_cvc);
        EditText number3 = findViewById(R.id.text_3num);
        String str="";

        //проверка на то введен ли номер карты
        if(number_of_card.length()==0) {
            Snackbar mSnackbar = Snackbar.make(view, "Введите номер карты", Snackbar.LENGTH_SHORT).setAction("Action", null);
            SnackbarSHOW(mSnackbar);
        }
        else{
            str=number_of_card.getText().toString();
            int real_size=0;
            //проверка на то,содрежит ли номер карты " " или "-"
            if((str.contains(" ") || str.contains("-")) && str.length()==19) {
                cvc = findViewById(R.id.text_cvc);

                if (cvc.length() == 0) {
                    Snackbar mSnackbar = Snackbar.make(view, "Введите cvc", Snackbar.LENGTH_SHORT).setAction("Action", null);
                    SnackbarSHOW(mSnackbar);
                } else {
                    //если cvc введен получаем его
                    str = cvc.getText().toString();
                    //проверка на правильность его ввода
                    if (str.contains("/") && str.length() == 5 && (Integer.parseInt(str.substring(0, 2)) < 13 && Integer.parseInt(str.substring(3, 5)) > 21)) {
                        //если все хорошо,получаем данные с разворота
                        number3 = findViewById(R.id.text_3num);

                        if (number3.length() == 0) {
                            Snackbar mSnackbar = Snackbar.make(view, "Введите цифры с разворота карты", Snackbar.LENGTH_SHORT).setAction("Action", null);
                            SnackbarSHOW(mSnackbar);
                        } else if (number3.getText().toString().length() != 3) {
                            Snackbar mSnackbar = Snackbar.make(view, "Данные введене не верно", Snackbar.LENGTH_SHORT).setAction("Action", null);
                            SnackbarSHOW(mSnackbar);
                        } else {
                            Toast toast = Toast.makeText(getApplicationContext(),
                                    "Оплата прошла успешно", Toast.LENGTH_SHORT);
                            toast.show();

                            Context context = PayActivity.this;
                            Class mActivity = MenuActivity.class;
                            Intent menuActivity = new Intent(context, mActivity);
                            startActivity(menuActivity);
                        }
                    } else {
                        Snackbar mSnackbar = Snackbar.make(view, "cvc введен не верно", Snackbar.LENGTH_SHORT).setAction("Action", null);
                        SnackbarSHOW(mSnackbar);
                    }
                }
            }
            else {
                Snackbar mSnackbar = Snackbar.make(view, "Номер карты введен не верно", Snackbar.LENGTH_SHORT).setAction("Action", null);
                SnackbarSHOW(mSnackbar);
            }
        }
    }
}