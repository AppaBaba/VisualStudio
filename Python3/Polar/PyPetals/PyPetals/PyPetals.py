from numpy import arange, sin, pi
from pylab import polar, show
a = 1
n = 3
t = arange(0, 2*pi, .01)
polar(t, a * sin(t * n))
show()
