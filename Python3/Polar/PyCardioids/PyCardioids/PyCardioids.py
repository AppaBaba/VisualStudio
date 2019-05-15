def menu():     
    print '1. Sin Option 1'
    print "2. Menu Option 2"
    print "3. Menu Option 3"
    print "4. Menu Option 4"
    print "5. Exit"
loop = True

from numpy import arange, sin, pi
from pylab import polar, show

astring = input ('Enter a: ')
bstring = input ('Enter b: ')
a = int(astring)
b = int(bstring)

menu = {}
menu['1']="Sin(t)" 
menu['2']="-Sin(t)."
menu['3']="Cos(t)"
menu['4']="-Cod(t)"
while True: 
  options=menu.keys()
  options.sort()
    for entry in options: 
      print entry, menu[entry]

    selection=raw_input("Please Select:") 
    if selection =='1': 
      t = arange(0, 2*pi, .01)
      polar(t, a + (b * sin(t)))
      show()
    elif selection == '2':  
      t = arange(0, 2*pi, .01)
      polar(t, a + (b * -sin(t)))
      show()
    elif selection == '3':
      t = arange(0, 2*pi, .01)
      polar(t, a + (b * cos(t)))
      show()
    elif selection == '4': 
      t = arange(0, 2*pi, .01)
      polar(t, a + (b * -cos(t)))
      show()
    else: 
      print "Unknown Option Selected!
