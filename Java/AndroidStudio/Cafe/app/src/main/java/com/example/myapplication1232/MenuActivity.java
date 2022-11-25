package com.example.myapplication1232;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.content.Intent;
import android.os.Bundle;
import android.view.MenuItem;
import android.view.View;
import android.widget.TextView;

public class MenuActivity extends AppCompatActivity {

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
        setContentView(R.layout.menu);
    }

    protected void onResume(Bundle savedInstanceState){
        getSupportActionBar().hide();
    }


    public int size_of_all_eat=7;
    public static int[] count = new int[6];

    //ф-ия нажатия на кнопку добавить (еду в корзину)
    public void plus(int i,TextView text){
        //проверка на то.чтобы нельзя было купить много одинаковых продуктов(еды)
        if (count[i] !=99) {
            count[i] += 1;
        }
        //заносим кол-во еды
        String str=Integer.toString(count[i]);
        text.setText(str, TextView.BufferType.EDITABLE);
    }

    public void choose_plus(View view){
        int i=0;
        TextView count_of_eat;

        //проверка на то,какая кнопка была нажата(к какой еде она относится)
        switch (view.getId()) {
            case R.id.b_plus0:
                i = 0;
                count_of_eat = findViewById(R.id.count_of_eat0);
                plus(i,count_of_eat);
                break;
            case R.id.b_plus1:
                i=1;
                count_of_eat = findViewById(R.id.count_of_eat1);
                plus(i,count_of_eat);
                break;
            case R.id.b_plus2:
                i = 2;
                count_of_eat = findViewById(R.id.count_of_eat2);
                plus(i,count_of_eat);
                break;
            case R.id.b_plus3:
                i=3;
                count_of_eat = findViewById(R.id.count_of_eat3);
                plus(i,count_of_eat);
                break;
            case R.id.b_plus4:
                i = 4;
                count_of_eat = findViewById(R.id.count_of_eat4);
                plus(i,count_of_eat);
                break;
            case R.id.b_plus5:
                i=5;
                count_of_eat = findViewById(R.id.count_of_eat5);
                plus(i,count_of_eat);
                break;
        }
    }

    public void minus(int i,TextView text){
        //проверка на то.чтобы нельзя было купить много одинаковых продуктов(еды)
        if (count[i] !=0) {
            count[i] -= 1;
        }

        String str=Integer.toString(count[i]);
        //отображение кол-ва  еды в окне с кол-вом
        text.setText(str, TextView.BufferType.EDITABLE);

    }

    //ф-ия нажатия на кнопку убрать (еду из корзину)
    public void choose_minus(View view){
        int i=0;
        TextView count_of_eat;

        //проверка на то,какая кнопка была нажата(к какой еде она относится)
        switch(view.getId()) {
            case R.id.b_minus0:
                i=0;
                count_of_eat= findViewById(R.id.count_of_eat0);
                minus(i,count_of_eat);
                break;

            case R.id.b_minus1:
                i=1;
                count_of_eat= findViewById(R.id.count_of_eat1);
                minus(i,count_of_eat);
                break;
            case R.id.b_minus2:
                i=2;
                count_of_eat= findViewById(R.id.count_of_eat2);
                minus(i,count_of_eat);
                break;

            case R.id.b_minus3:
                i=3;
                count_of_eat= findViewById(R.id.count_of_eat3);
                minus(i,count_of_eat);
                break;
            case R.id.b_minus4:
                i=4;
                count_of_eat= findViewById(R.id.count_of_eat4);
                minus(i,count_of_eat);
                break;

            case R.id.b_minus5:
                i=5;
                count_of_eat= findViewById(R.id.count_of_eat5);
                minus(i,count_of_eat);
                break;
        }
    }

    //ф-ия нажатия на кнопку корзина
    public void trash(View view){
        int size=0;
        int selected_eat=0;

        Context context=MenuActivity.this;
        Class tActivity=TrashActivity.class;
        Intent trashActivity = new Intent(context,tActivity);

        for(int i=0,k=0;i!=size_of_all_eat-1;i++) {
            if(count[i]>0) {
                trashActivity.putExtra("count"+k,count[i]);
                if("burger01".contains(""+i)) {
                    trashActivity.putExtra("image" + k, "burger01");
                    if(i==0)
                        trashActivity.putExtra("name" + k, "Бургер");
                    else
                        trashActivity.putExtra("name" + k, "Чизбургер");

                } else if("cofe23".contains(""+i)) {
                    trashActivity.putExtra("image" + k, "cofe23");
                    if(i==2)
                        trashActivity.putExtra("name" + k, "Капучино");
                    else
                        trashActivity.putExtra("name" + k, "Американо");

                } else if("cheesecake4".contains(""+i)) {
                    trashActivity.putExtra("image" + k, "cheesecake4");
                    trashActivity.putExtra("name" + k, "Чизкейк");
                } else if("cookie5".contains(""+i)){
                    trashActivity.putExtra("image" + k, "cookie5");
                    trashActivity.putExtra("name" + k, "Пироженое");
                }
                k++;
                size+=count[i];
                selected_eat++;
            }
        }
        trashActivity.putExtra("count",selected_eat);
        trashActivity.putExtra("all_size",size);
        startActivity(trashActivity);
    }
}