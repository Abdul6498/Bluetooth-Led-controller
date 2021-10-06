/*
 * Serial Read Basic
 * -----------------
 * Blink the pin 13 LED if an 'H' is received over the serial port
 *
 * 
 */
   // select the pin for the LED
char val;       // variable to store the data from the serial port

void setup() {
  pinMode(5,OUTPUT);    // declare the LED's pin as output
  pinMode(6,OUTPUT);
  pinMode(7,OUTPUT);
  pinMode(8,OUTPUT);
  pinMode(9,OUTPUT);
  pinMode(10,OUTPUT);
  pinMode(11,OUTPUT);
  pinMode(12,OUTPUT);
  Serial.begin(9600);        // connect to the serial port
}

void loop () {
  // Serial.available() is a way to see if there's serial data
  // without pausing your code
  if( Serial.available() ) {
    val = Serial.read();      // read the serial port  
    Serial.println(char(val));
    if( val == 'Q' ) {        // if it's an 'H', blink the light
     digitalWrite(5, HIGH);
    } 
    if( val == 'W' ) {        // if it's an 'H', blink the light
     digitalWrite(6, HIGH);
    }
    if( val == 'E' ) {        // if it's an 'H', blink the light
     digitalWrite(7, HIGH);
    }
    if( val == 'R' ) {        // if it's an 'H', blink the light
     digitalWrite(8, HIGH);
    }
    if( val == 'T' ) {        // if it's an 'H', blink the light
     digitalWrite(9, HIGH);
    }
    if( val == 'Y' ) {        // if it's an 'H', blink the light
     digitalWrite(10, HIGH);
    }
    if( val == 'U' ) {        // if it's an 'H', blink the light
     digitalWrite(11, HIGH);
    }
    if( val == 'I' ) {        // if it's an 'H', blink the light
     digitalWrite(12, HIGH);
    }
    if( val == 'A' ) {        // if it's an 'H', blink the light
     digitalWrite(5, LOW);
    }
    if( val == 'S' ) {        // if it's an 'H', blink the light
     digitalWrite(6, LOW);
    }
    if( val == 'D' ) {        // if it's an 'H', blink the light
     digitalWrite(7, LOW);
    }
    if( val == 'F' ) {        // if it's an 'H', blink the light
     digitalWrite(8, LOW);
    }
    if( val == 'G' ) {        // if it's an 'H', blink the light
     digitalWrite(9, LOW);
    }
    if( val == 'H' ) {        // if it's an 'H', blink the light
     digitalWrite(10, LOW);
    }
    if( val == 'J' ) {        // if it's an 'H', blink the light
     digitalWrite(11, LOW);
    }
    if( val == 'K' ) {        // if it's an 'H', blink the light
     digitalWrite(12, LOW);
    }
    
  }

}

