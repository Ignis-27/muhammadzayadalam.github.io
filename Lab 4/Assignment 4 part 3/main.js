// setup canvas

const canvas = document.querySelector('canvas');
const ctx = canvas.getContext('2d');

const width = (canvas.width = window.innerWidth);
const height = (canvas.height = window.innerHeight);

// function to generate random number

function random(min, max) {
  const num = Math.floor(Math.random() * (max - min + 1)) + min;
  return num;
}

// function to generate random color

function randomRGB() {
  return `rgb(${random(0, 255)},${random(0, 255)},${random(0, 255)})`;
}
 

//modelling a ball 
class Ball {
  constructor(x,y,velX,velY,color,size) {
    this.x = x;
    this.y = y;
    this.velX = velX;
    this.velY = velY;
    this.color = color;
    this.size = size;

  }
}

// a method to draw ball

draw() {
  ctx.beginPath();
  ctx.fillStyle = this.color;
  ctx.arc(this.x,this.y,this.size,0,2 * Math.PI);
  ctx.fill();
}

//a new ball instance 

const testBall = new Ball (50,100,4,4,"blue",10);

testBall.x;
testBall.size;
testBall.color;
testBall.draw();