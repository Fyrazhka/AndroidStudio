package com.example.myapplication1232;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.content.Intent;
import android.graphics.Color;
import android.os.Bundle;
import android.view.MenuItem;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

import com.google.android.material.snackbar.Snackbar;

import java.util.Calendar;
import java.util.GregorianCalendar;

public class ChooseActivity extends AppCompatActivity {
    //возвращение на прошлое activity
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
        setContentView(R.layout.choose);
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

    //ф-ия проверки времени работы ресторана
    public void check(View view){
        Context context=ChooseActivity.this;

        GregorianCalendar calendar = new GregorianCalendar();
        int date=calendar.get(Calendar.HOUR_OF_DAY);

        //проверяем открыт ли ресторан в данное время
        if(date>=8 && date<20)
        {
            Class mActivity=MenuActivity.class;
            Intent menuActivity = new Intent(context,mActivity);
            startActivity(menuActivity);
        }
        else{
            Snackbar mSnackbar = Snackbar.make(view, "На данный момент кафе по этому адресу закрыто", Snackbar.LENGTH_SHORT).setAction("Action", null);
            SnackbarSHOW(mSnackbar);
        }
    }

    //ф-ия выбора адреса кафе
    public void choosecafe(View view){
        Button b;
        //смотрим какая кнопка(адрес) была нажата
        //нажатая кнопка становится синей(выделяется),остальные белыми
        switch(view.getId()) {
            case R.id.b_adress1:
                //установка синего цвета для кнопки
                findViewById(R.id.b_adress1).setBackgroundColor(Color.argb(247,192,232, 248));
                //установка белого цвета для кнопки
                findViewById(R.id.b_adress2).setBackgroundColor(Color.argb(255,255,255, 255));
                findViewById(R.id.b_adress3).setBackgroundColor(Color.argb(255,255,255, 255));
                break;
            case R.id.b_adress2:
                findViewById(R.id.b_adress2).setBackgroundColor(Color.argb(247,192,232, 248));

                findViewById(R.id.b_adress1).setBackgroundColor(Color.argb(255,255,255, 255));
                findViewById(R.id.b_adress3).setBackgroundColor(Color.argb(255,255,255, 255));
                break;
            case R.id.b_adress3:
                findViewById(R.id.b_adress3).setBackgroundColor(Color.argb(247,192,232, 248));

                findViewById(R.id.b_adress1).setBackgroundColor(Color.argb(255,255,255, 255));
                findViewById(R.id.b_adress2).setBackgroundColor(Color.argb(255,255,255, 255));
                break;
        }
        //после первого нажатия на любой из адресов появляется кнопка,которая позволяет перейти дальше в меню выбора еды,если кафе открыто
        findViewById(R.id.b_toMenu).setVisibility(View.VISIBLE);
    }
}