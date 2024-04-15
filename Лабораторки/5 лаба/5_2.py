class PersonalComputer:
    def __init__(self, processor, ram, storage):
        self.processor = processor
        self.ram = ram
        self.storage = storage

    def start(self):
        print("Starting the computer...")

    def shutdown(self):
        print("Shutting down the computer...")

    def run_program(self, program):
        print(f"Running program: {program}")

class Monitor:
    def __init__(self, size):
        self.size = size

    def display(self):
        print(f"Displaying content on a {self.size}-inch monitor...")

class Keyboard:
    def __init__(self, layout):
        self.layout = layout

    def type_text(self, text):
        print(f"Typing text: {text}")

class Mouse:
    def __init__(self, buttons):
        self.buttons = buttons

    def click(self):
        print("Mouse click")

class OperatingSystem:
    def __init__(self, name, version):
        self.name = name
        self.version = version

    def boot(self):
        print(f"Booting {self.name} {self.version}...")

    def shutdown(self):
        print(f"Shutting down {self.name} {self.version}...")

class Application:
    def __init__(self, name, version):
        self.name = name
        self.version = version

    def run(self):
        print(f"Running {self.name} {self.version}...")

# Пример использования:
computer = PersonalComputer("Intel Core i7", "16GB", "512GB SSD")
computer.start()
computer.run_program("Web browser")
computer.shutdown()

monitor = Monitor(24)
monitor.display()

keyboard = Keyboard("QWERTY")
keyboard.type_text("Hello, World!")

mouse = Mouse(2)
mouse.click()

os = OperatingSystem("Windows", "10")
os.boot()
os.shutdown()

app = Application("Microsoft Word", "2021")
app.run()
