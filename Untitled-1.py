def add_tel():
    data = [
        input("Введите фамилию: "),
        input("Введите имя: "),
        input("Введите отчество: "),
        input("Введите номер телефона: ")
    ]
    #data = list(enumerate(add_tel()))
    users = list(enumerate(data))
    #print(users)
    #st = " ".join(data)
    with open('file.txt', "a") as file:
        for index, field in users:
            file.write(f"{field}")
        file.write("\n")
        print('Номер записан!')
   
def get_guide():
    with open('file.txt', "r") as file:
        contacts = file.read().split('\n')
        for contact in contacts:
            print(f'Фамилия: {contact[0]}, Имя: {contact[1]}, Отчество: {contact[2]}, Номер: {contact[3]}')
def menu():
    dct = {
        "cr": 'Добавить запись (введите "cr")',
        "sh": 'Вывести справочник (введите "sh")',
        "ex": 'Выйти из программы (введите "ex")',
    }
    print("-", dct["cr"])
    print("-", dct["sh"])
    print("-", dct["ex"])
    cmd = input('Введите команду: ')
    if cmd not in dct:
        print("Такой команды нет, выбирите другую")
        return -1
    else:
        return cmd


while True:
    cmd = menu()
    if cmd == "cr":
        add_tel()
    elif cmd == "sh":
        get_guide()
    else:
        exit()
    input('Нажмите enter, чтобы продолжить')

