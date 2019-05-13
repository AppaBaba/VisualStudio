from numpy import arange, sin, pi
from pylab import polar, show
a = 6
b = 1
t = arange(0, 2*pi, .01)
polar(t, a + (b * sin(t)))
show()
