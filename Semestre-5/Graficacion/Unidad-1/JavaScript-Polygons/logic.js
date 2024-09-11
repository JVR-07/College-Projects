var canvas = null;
var context = null;

    window.onload = function(){
        canvas = document.getElementById("drawing");
        pen = canvas.getContext("2d");
    }

    function ClearCanvas(){
        pen.clearRect(0,0,canvas.width,canvas.height)
    }

    function drawPolygon(radius, sides){
        ClearCanvas();
        pen.translate(canvas.width/2, canvas.height/2);
        var a = ((Math.PI * 2) / sides);
        pen.beginPath();
        pen.moveTo(radius, 0);
        for (var i = 1; i < sides; i++) {
            pen.lineTo(radius * Math.cos(a*i),radius*Math.sin(a*i))
        }
        pen.closePath();
        pen.lineWidth = 3;
        color = document.getElementById("colorPicker");
        pen.strokeStyle = color.value;
        pen.fillStyle = color.value;
        pen.fill();
        pen.stroke();
        pen.translate(-1*canvas.width/2,-1*canvas.height/2);
    }

    function Pentagon(){
        drawPolygon(150,5);
    }

    function Hexagon(){
        drawPolygon(150,6);
    }

    function Octagon(){
        drawPolygon(150,8);
    }