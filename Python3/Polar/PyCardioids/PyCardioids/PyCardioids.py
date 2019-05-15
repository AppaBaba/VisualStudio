from numpy import arange, sin, pi
from pylab import polar, show

astring = input ('Enter a: ')
bstring = input ('Enter b: ')
a = int(astring)
b = int(bstring)

t = arange(0, 2*pi, .01)
polar(t, a + (b * sin(t)))
show()
