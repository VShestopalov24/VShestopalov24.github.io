import random

koloda=[6,7,8,9,10,2,3,4,11]*10000
random.shuffle(koloda)
count=0
looses=0
wins=0

while True:
  if count==0:
    print("------------")
    print("Новый раунд!")
    print("------------")
  choice=input('Будете брать карту? y/n\n')
  if choice=='y':
    current=koloda.pop()
    print("")
    print('Вам попалась карта достоинством %d' %current)
    count+=current
    if count>21:
      print('Итого %d очков.\n' %count)
      print('Извините, но вы проиграли. :-(\n')
      
    elif count==21:
      print('Поздравляю, вы набрали 21!')
      
    else:
      print('Итого %d очков.' %count)
    if count>=21:
      if count==21:wins=wins+1
      if count>21:looses=looses+1
      print("Статистика: %d побед," %wins, "%d поражений.\n" %looses)
      count=0
  elif choice=='n':
    print('Статистика: %d побед,' %wins, '%d поражений.\n' %looses)
    break
print('До новых встреч!')
