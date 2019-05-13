from numpy import arange, sin, pi
from pylab import polar, show

astring = input ('Enter a: ')
nstring = input ('Enter n: ')
a = int(astring)
n = int(nstring)

t = arange(0, 2*pi, .01)
polar(t, a * sin(t * n))
show()
