class carcolordefinition:


    def __init__(self, color):
        self__color = color


@property
def color(self):
    return self.__color

@color.setter
def color(self, color_temp):
    self.__color = color_temp


class CarCabin(carcolordefinition):
    def __init__(self, cabin_type, cabin_width, cabin_heigth, color):
        super().__init__(color)
        self.__cabin_type = cabin_type
        self.__cabin_width = cabin_width
        self.__cabin_height = cabin_heigth

@property
def cabin_type(self):
    return self.__cabin_type

@cabin_type.setter
def cabin_type(self, cabin_type_temp):
    if cabin_type_temp == "Hatchback" or "Sedan" or "Liftback":
        self.__cabin_type = cabin_type_temp
    else:
        raise ValueError

@property
def cabin_width(self):
    return self.__cabin_width

@cabin_width.setter
def cabin_width(self, cabin_witdh_temp):
    if cabin_witdh_temp > 0:
        self.__cabin_width = cabin_witdh_temp
    else:
        raise ValueError
    
@property
def cabin_heigth(self):
    return self.__cabin_height

@cabin_heigth.setter
def cabin_heigth(self, cabin_heigth_temp):
    if cabin_heigth_temp > 0:
        self.__cabin_height = cabin_heigth_temp
    else:
        raise ValueError
    


car_value = CarCabin("Hatchback", 10, 10, "red")

print(car_value.cabin_type)
print(car_value.cabin_width)
print(car_value.cabin_height)