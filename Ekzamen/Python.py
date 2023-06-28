# This is a sample Python script.

# Press Shift+F10 to execute it or replace it with your code.
# Press Double Shift to search everywhere for classes, files, tool windows, actions, and settings.


person_dict = {
    'person_id': [41, 72, 41],
    'person_name': ['Keanu Reeves', 'Jim Carrey']
}

travel_log = {
    'travel_id': [101, 102, 105],
    'person_id': [41, 72, 41],
    'country': ['USA', 'Japan', 'China']
}
person_name = input("Введите кто Вам нужен: ")

if person_name in person_dict['person_name']:
    person_id = person_dict['person_id'][person_dict['person_name'].index(person_name)]
    countries = [travel_log['country'][i] for i in range(len(travel_log['travel_id'])) if travel_log['person_id'][i] == person_id]

    if len(countries) == 0:
        print('None')
    elif len(set(countries)) == 1:
        print(countries[0])
    else:
        print('several')
