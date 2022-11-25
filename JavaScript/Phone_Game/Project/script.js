function newdiscription(){
  document.getElementById("discription").innerHTML='';
  document.getElementById("discription").innerHTML+=`Move: ${move}`+'<br>';
  document.getElementById("discription").innerHTML+=`difficulty: ${difficulty}`+'<br>';
}
function genmap(diff){
  difficulty=diff;
  for(let i=0;i!=sizeofmap;i++)
  {
    for(let j=0;j!=sizeofmap;j++)
    {
      if(difficulty>=5){
        if(i==2 && j==6)
        {
          map[i][j]=6;
        }
      }
      if(i==3 && j==9)
      {
        map[i][j]=8;
      }
      else if(i==7 && j==3)
      {
        map[i][j]=5;
      }
      else if(i==2 && j==2)
      {
        map[i][j]=6;
      }
      else if(i==0 || i==(sizeofmap-1) || j==0 || j==(sizeofmap-1))
      {
        map[i][j]=0;
      }        
      else
      {
        map[i][j]=2;
      }
    }
  }
  switch(difficulty){
    case 1:
        move=40;
	document.getElementById("b0image").style.visibility = "hidden";
        break;
    case 2:
        move=30;
	document.getElementById("b0image").style.visibility = "hidden";
        break;
    case 3:
        move=20;
	document.getElementById("b0image").style.visibility = "hidden";
        break;
    case 4:
        move=16;
	document.getElementById("b0image").style.visibility = "hidden";
        break;
    case 5:
        move=13;
	document.getElementById("b0image").style.visibility = "visible";
        break;
    case 6:
        move=10;
	document.getElementById("b0image").style.visibility = "visible";
        break;
    case 7: 
      document.getElementById("firstbutton").style.display = 'none';
      document.getElementById("secondbutton").style.display = 'none';
      document.getElementById("discription").style.display = 'none';
      document.getElementById("map").style.display = 'none';
      document.getElementById("endbutton").style.display = 'block';
      document.getElementById("door").style.display = 'none';
      break;
  }
  newdiscription();


  lose=false;
  mystarty=7;
  mystartx=3;
  botstarty=[2,2];
  botstartx=[6,2];

  document.getElementById("pimage").style.marginTop=`${(mystarty*20)}px`;
  document.getElementById("pimage").style.marginLeft=`${(mystartx*20)}px`;

  document.getElementById("b0image").style.marginTop=`${(botstarty[0]*20)}px`;
  document.getElementById("b0image").style.marginLeft=`${(botstartx[0]*20)}px`;
  document.getElementById("b1image").style.marginTop=`${(botstarty[1]*20)}px`;
  document.getElementById("b1image").style.marginLeft=`${(botstartx[1]*20)}px`;
}

function startgame()
{
  document.getElementById("application").style.display = 'none';
  document.getElementById("map").style.display = 'block';
  document.getElementById("firstbutton").style.display = 'block';
  document.getElementById("secondbutton").style.display = 'block';
  document.getElementById("discription").style.display = 'block';
  document.getElementById("door").style.display = 'block';
  genmap(1);
}
function finishgame(){
  document.getElementById("application").style.display = 'block'; 
  document.getElementById("endbutton").style.display = 'none';
}

function nextlvl(){
  genmap((difficulty+1)); 
}

function mymove(where){
   switch(where)
   {
     case 1:       
          if(map[mystarty-1][mystartx]!=0)
          {
            if(map[mystarty-1][mystartx]==6)
            {
              lose=true;
            }
            document.getElementById("pimage").style.marginTop=`${(mystarty*20)-20}px`;
            map[mystarty][mystartx]=2;
            mystarty-=1;
            map[mystarty][mystartx]=5;
            move--;
            newdiscription();
            if(lose==true)
            {             
              alert("You lose");
              genmap(difficulty);
              break;
            }
          }
          else
          {
              alert("Exit of map");
          }
          break;
      case 2:
          if(map[mystarty+1][mystartx]!=0 )
          {
            if(map[mystarty+1][mystartx]==6)
            {
              lose=true;
            }
            document.getElementById("pimage").style.marginTop=`${(mystarty*20)+20}px`;
            map[mystarty][mystartx]=2;
            mystarty+=1;
            map[mystarty][mystartx]=5;
            move--;
            newdiscription();
            if(lose==true)
            {
              alert("You lose");
              genmap(difficulty);
              break;
            }
          }
          else{
            alert("Exit of map");
          }
          break;
      case 3:
          if(map[mystarty][mystartx+1]!=0 && map[mystarty][mystartx+1]!=8)
          {
            if(map[mystarty][mystartx+1]==6)
            {
              lose=true;
            }
            document.getElementById("pimage").style.marginLeft=`${(mystartx*20)+20}px`;
            map[mystarty][mystartx]=2;
            mystartx+=1;
            map[mystarty][mystartx]=5;
            move--;
            newdiscription();
            if(lose==true)
            {
              alert("You lose");
              genmap(difficulty);
              break;
            }         
          }
          else{
            if(map[mystarty][mystartx+1]==8)
            {
              document.getElementById("pimage").style.marginLeft=`${(mystartx*20)+20}px`;
              alert("Congratulations")
              nextlvl();
              break;
            }
            else
            {
              alert("Exit of map");
            }
          }
          break;
      case 4:
          if(map[mystarty][mystartx-1]!=0)
          {
            if(map[mystarty][mystartx-1]==6)
            {
              lose=true;
            }
            document.getElementById("pimage").style.marginLeft=`${(mystartx*20)-20}px`;
            map[mystarty][mystartx]=2;
            mystartx-=1;
            map[mystarty][mystartx]=5;
            move--;
            newdiscription();
            if(lose==true)
            {
              alert("You lose");
              genmap(difficulty);
              break;
            }
          }
          else{
            alert("Exit of map");
          } 
          break;
   }
}

function botmove(where,boty,botx,i){
   switch(where)
   {
     case 1: 
          if(map[boty-1][botx]!=0 && map[boty-1][botx]!=6) 
          {
            if(map[boty-1][botx]==5)
            {
              lose=true;
            }
            console.log(document.getElementById(`b${i}image`).style.marginTop);
            document.getElementById(`b${i}image`).style.marginTop=`${(boty*20)-20}px`;
            map[boty][botx]=2;
            boty-=1;
            map[boty][botx]=6;            
            if(lose==true)
            {
              alert("You lose");
              genmap(difficulty);
              break;
            }
          }    
          return boty;
          break;          
      case 2:
          if(map[boty+1][botx]!=0 && map[boty-1][botx]!=6)
          {
            if(map[boty+1][botx]==5)
            {
              lose=true;
            }
            document.getElementById(`b${i}image`).style.marginTop=`${(boty*20)+20}px`;
            map[boty][botx]=2;
            boty+=1;
            map[boty][botx]=6;
            if(lose==true)
            {
              alert("You lose");
              genmap(difficulty);
              break;
            }
          }
          return boty;
          break;
      case 3:
          if(map[boty][botx+1]!=0 && map[boty][botx+1]!=8 && map[boty-1][botx]!=6)
          {
            if(map[boty][botx+1]==5)
            {
              lose=true;
            }
            document.getElementById(`b${i}image`).style.marginLeft=`${(botx*20)+20}px`;
            map[boty][botx]=2;
            botx+=1;
            map[boty][botx]=6;
            if(lose==true)
            {
              alert("You lose");
              genmap(difficulty);
              break;
            }
          }
          return botx;
          break;         
      case 4:
          if(map[boty][botx-1]!=0 && map[boty-1][botx]!=6)
          {
            if(map[boty][botx-1]==5)
            {
              lose=true;
            }
            document.getElementById(`b${i}image`).style.marginLeft=`${(botx*20)-20}px`;
            map[boty][botx]=2;
            botx-=1;
            map[boty][botx]=6;
            if(lose==true)
            {
              alert("You lose");
              genmap(difficulty);
              break;
            }
          }   
          return botx;
          break;      
   }
}

function genbotmove2(i)
{
  side=Math.floor(Math.random()*3)+1;
  switch(side)
  {
    case 1:
      botstarty[i]=botmove(1,botstarty[i],botstartx[i],i);
      break;
    case 2:
      botstarty[i]=botmove(2,botstarty[i],botstartx[i],i);
      break;
    case 3:
      botstartx[i]=botmove(3,botstarty[i],botstartx[i],i);
      break;
    case 4:
      botstartx[i]=botmove(4,botstarty[i],botstartx[i],i);
      break;
  }
}
function genbotmove(){

  if(difficulty>=5)
  {
    genbotmove2(0);
    genbotmove2(1);
  }
  else{
    genbotmove2(1);
  }

}


let sizeofmap=10;
let map=new Array(sizeofmap);
for(let i=0;i!=sizeofmap;i++)
{
  map[i]=new Array(sizeofmap);
}

let difficulty=0;
let lose=false;
let move=1;
let mystarty=7;
let mystartx=3;
let botstarty=[2,2];
let botstartx=[6,2];
let side=0;


document.addEventListener('keyup', function(event) 
{
    if(move==0)
    {
     alert("You lose");
     genmap(difficulty);
    }
    switch(event.code)
    {
      case "ArrowUp":
          mymove(1);
          genbotmove();
          break;
      case "ArrowDown":
          mymove(2);
          genbotmove();
          break;
      case "ArrowRight":
          mymove(3);
          genbotmove();
          break;
      case "ArrowLeft":
          mymove(4);
          genbotmove();
          break;
    }
});


localStorage.removeItem('toClient');
window.addEventListener('storage', receiveFromServer);


function receiveFromServer(event)
{
	if(event.key == 'toClient'){
		objFromEden =JSON.parse(localStorage.getItem('toClient'));
		difficulty=objFromEden;
    console.log("load succesfull");	
    genmap(difficulty);
		localStorage.removeItem('toClient');
	}
}

function sendToServer1()          
{
    console.log("load");	
    jsonString=JSON.stringify("load");	
		localStorage.setItem('toServer',jsonString);
}

function sendToServer2()       
{
    console.log("save");	
    jsonString=JSON.stringify(difficulty);
		localStorage.setItem('toServer', jsonString);
}
