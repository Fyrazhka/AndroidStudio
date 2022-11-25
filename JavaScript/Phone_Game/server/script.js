//работа с локальным хранилещем 
localStorage.removeItem('toServer');
window.addEventListener('storage', receiveFromClient);
console.log("start");
save = 1; //переменная хранящая сохранение 
//функция обработки запроса клиента
function receiveFromClient(event){
    if(event.key == 'toServer')
    {
	    objFromClient = JSON.parse(localStorage.getItem('toServer'));
      //проверка какие данные были получены
      if(objFromClient=="load") //отправка сложноности клиенту (15)
      {
       	console.log("toclient");
        localStorage.setItem('toClient', JSON.stringify(save));
	      localStorage.removeItem('toServer');
      }
      else //сохранение сложноности на сервере(21)
      {
        console.log("newsave");
	      save=objFromClient;
      }
	}
}