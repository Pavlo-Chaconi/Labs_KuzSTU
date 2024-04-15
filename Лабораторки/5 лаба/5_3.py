import math

class Shape:
    def __init__(self, x, y):
        self.x = x
        self.y = y
    
    def resize(self, factor):
        pass

    def rotate(self, angle):
        pass
    

    def move(self, dx, dy):
        self.x += dx
        self.y += dy

class Circle(Shape):
    def __init__(self, x =0, y=0, radius=0):
        super().__init__(x, y)
        self.radius = radius
    
    def resize(self, factor):
        self.radius *=factor
    
    def __str__(self):
        return f"Круг при значениях({self.x}, {self.y} с радиусом {self.radius})"
    
class Square(Shape):
    def __init__(self, x=0, y=0, side_length=1):
        super().__init__(x, y)
        self.side_length = side_length

    def resize(self, factor):
        self.side_length *= factor

    def __str__(self):
        return f"Квадрат при значениях({self.x}, {self.y} с боковой стороной {self.side_length})"
    
class Rectangle(Shape):
    def __init__(self, x=0, y=0, width=1, heigth=1):
        super().__init__(x, y)
        self.width = width
        self.heigth = heigth

    def resize(self, factor):
        self.width *= factor
        self.heigth *= factor

    def rotate(self, angle):
        radians = math.radians(angle)
        cos_theta = math.cos(radians)
        sin_theta = math.sin(radians)
        new_width = abs(self.width * cos_theta) + abs(self.heigth * sin_theta)
        new_heigth = abs(self.width * sin_theta) + abs(self.heigth * cos_theta)
        self.width, self.heigth = new_width, new_heigth

    def __str__(self):
        return f"Треугольник на значениях ({self.x}, {self.y} с шириной {self.width} и высотой {self.heigth})"


circle = Circle(4, 2, 1)
print(circle)  
square = Square(0, 0, 4)
print(square)  

rectangle = Rectangle(-1, -1, 3, 2)
print(rectangle) 