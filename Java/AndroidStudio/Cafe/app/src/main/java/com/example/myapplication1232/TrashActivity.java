package com.example.myapplication1232;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.content.Intent;
import android.graphics.Color;
import android.graphics.drawable.BitmapDrawable;
import android.graphics.drawable.Drawable;
import android.os.Bundle;
import android.view.MenuItem;
import android.view.View;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.LinearLayout;
import android.widget.RelativeLayout;
import android.widget.ScrollView;
import android.widget.TextView;
import android.widget.Toast;

import com.google.android.material.snackbar.Snackbar;

import java.io.InputStream;

public class TrashActivity extends AppCompatActivity {

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

        Context context=this;
        RelativeLayout relativeLayout=new RelativeLayout(context);
        RelativeLayout.LayoutParams relativeLayoutParam = new RelativeLayout.LayoutParams(RelativeLayout.LayoutParams.MATCH_PARENT, RelativeLayout.LayoutParams.MATCH_PARENT);
        relativeLayout.setBackgroundResource(R.drawable.back);

        setContentView(relativeLayout, relativeLayoutParam);


        Bundle arguments = getIntent().getExtras();
        int size_of_all_selected_eat=arguments.getInt("all_size");
        int size_of_selected_eat=arguments.getInt("count");

        int[] count=new int[size_of_selected_eat];
        String[] image_name=new String[size_of_selected_eat];
        String[] name_of_eat=new String[size_of_selected_eat];
        for(int i=0;i!=size_of_selected_eat;i++) {
            count[i] = arguments.getInt("count" + i);
            image_name[i] = arguments.getString("image" + i);
            name_of_eat[i]=arguments.getString("name" + i);
        }
        int cost=3*size_of_all_selected_eat;

        RelativeLayout.LayoutParams button_view = new RelativeLayout.LayoutParams(RelativeLayout.LayoutParams.MATCH_PARENT, RelativeLayout.LayoutParams.WRAP_CONTENT);
        button_view.topMargin=2050;
        button_view.height=200;
        Button b_to_pay = new Button(context);
        b_to_pay.setTextSize(20);
        b_to_pay.setTextColor(Color.argb(255, 0, 0, 0));
        b_to_pay.setBackgroundColor(Color.argb(255, 255, 255, 255));
        b_to_pay.setText("Перейти к оплате");

        View.OnClickListener click_on_button = new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Context context_click=TrashActivity.this;
                Class pActivity=PayActivity.class;
                Intent payActivity = new Intent(context_click,pActivity);
                startActivity(payActivity);
            }
        };
        b_to_pay.setOnClickListener(click_on_button);

        relativeLayout.addView(b_to_pay, button_view);


        RelativeLayout.LayoutParams scroll_view = new RelativeLayout.LayoutParams(RelativeLayout.LayoutParams.MATCH_PARENT, RelativeLayout.LayoutParams.MATCH_PARENT);
        scroll_view.topMargin=263;

        ScrollView scrollView=new ScrollView(context);
        scrollView.setScrollBarSize(0);
        relativeLayout.addView(scrollView,scroll_view);




        RelativeLayout.LayoutParams text_view_cost = new RelativeLayout.LayoutParams(RelativeLayout.LayoutParams.MATCH_PARENT, RelativeLayout.LayoutParams.MATCH_PARENT);
        text_view_cost.topMargin=1900;
        text_view_cost.height=200;

        TextView count_of_eat=new TextView(context);
        count_of_eat.setTextSize(20);
        count_of_eat.setTextColor(Color.argb(255, 0, 0, 0));
        count_of_eat.setBackgroundColor(Color.argb(255, 255, 255, 255));

        count_of_eat.setText("К оплате: "+cost+".0 р");
        relativeLayout.addView(count_of_eat,text_view_cost);

        LinearLayout parent_for_linear_layout=new LinearLayout(context);
        LinearLayout.LayoutParams parent_linear_view=new LinearLayout.LayoutParams(LinearLayout.LayoutParams.MATCH_PARENT, LinearLayout.LayoutParams.MATCH_PARENT);
        parent_for_linear_layout.setOrientation(LinearLayout.VERTICAL);
        LinearLayout.LayoutParams linear_view=new LinearLayout.LayoutParams(LinearLayout.LayoutParams.WRAP_CONTENT, LinearLayout.LayoutParams.WRAP_CONTENT);

        scrollView.addView(parent_for_linear_layout,parent_linear_view);


        LinearLayout[] linear_layout=new LinearLayout[size_of_selected_eat];

        LinearLayout.LayoutParams image_view=new LinearLayout.LayoutParams(LinearLayout.LayoutParams.WRAP_CONTENT, LinearLayout.LayoutParams.WRAP_CONTENT);
        image_view.setMargins(20,20,20,20);
        image_view.height=280;
        image_view.width=280;

        ImageView[] imageView=new ImageView[size_of_selected_eat];

        LinearLayout.LayoutParams text_view_count=new LinearLayout.LayoutParams(LinearLayout.LayoutParams.WRAP_CONTENT, LinearLayout.LayoutParams.WRAP_CONTENT);
        text_view_count.leftMargin=30;
        text_view_count.topMargin=110;

        TextView[] count_view=new TextView[size_of_selected_eat];

        LinearLayout.LayoutParams text_view_name=new LinearLayout.LayoutParams(LinearLayout.LayoutParams.WRAP_CONTENT, LinearLayout.LayoutParams.WRAP_CONTENT);
        text_view_name.leftMargin=30;
        text_view_name.topMargin=110;

        TextView[] name_view=new TextView[size_of_selected_eat];


        int resID =0;
        for(int i=0;i!=size_of_selected_eat;i++) {
            imageView[i]=new ImageView(context);
            count_view[i]=new TextView(context);
            name_view[i]=new TextView(context);
            name_view[i].setTextSize(20);
            count_view[i].setTextSize(20);

            linear_layout[i]=new LinearLayout(context);
            linear_layout[i].setBackgroundColor(Color.argb(255, 255, 255, 255));
            parent_for_linear_layout.addView(linear_layout[i],1200,400);

            resID=getResources().getIdentifier(image_name[i] , "drawable", getPackageName());
            imageView[i].setImageDrawable(getResources().getDrawable(resID));
            count_view[i].setText(""+count[i]);
            name_view[i].setText(""+name_of_eat[i]);

            linear_layout[i].addView(imageView[i],image_view);
            linear_layout[i].addView(name_view[i],text_view_name);
            linear_layout[i].addView(count_view[i],text_view_count);
        }

        TextView no_use=new TextView(context);
        no_use.setText("");
        LinearLayout.LayoutParams no_use_view = new LinearLayout.LayoutParams(LinearLayout.LayoutParams.MATCH_PARENT, LinearLayout.LayoutParams.WRAP_CONTENT);
        no_use.setBackgroundColor(Color.argb(255, 255, 255, 255));
        no_use.setMinHeight(250);
        parent_for_linear_layout.addView(no_use,no_use_view);

    }
    protected void onResume(Bundle savedInstanceState){
        getSupportActionBar().hide();
    }


}