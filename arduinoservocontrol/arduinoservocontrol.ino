#include <Servo.h>

Servo serwo1;

char data;
String con;
char d2_con;
int data_int = 0;
char buffer[4];
byte index = 0;

void setup() {
  Serial.begin(9600);
  pinMode(13, OUTPUT);
  d2_con = 'S';
  serwo1.attach(9);
}

void loop() {

  //inicjalizacja proby polaczenia
  if(Serial.available()>0 && d2_con == 'S'){  
    con = Serial.readString();
    d2_con = con.charAt(0);
  }                           //Jesli polaczono to d2_con = C 

  //zwroc informacje o polaczeniu
  if(d2_con == 'C'){
    Serial.println("D");
    d2_con = 'D';
    }

    
  if(Serial.available()>0 && d2_con == 'D'){
    data = Serial.read();
    if(data == '\n'){
      buffer[index] = '\0';
      index = 0;
      
      if(buffer[0] == 'A'){
        digitalWrite(13, HIGH);
      }
      else if(buffer[0] == 'B'){
        digitalWrite(13, LOW);
      }
      else
      {
        data_int = atoi(buffer);
        serwo1.write(data_int+60);
      }
    }
    else if(index < 3){
      buffer[index++] = data;
    }
    }
    
  }
