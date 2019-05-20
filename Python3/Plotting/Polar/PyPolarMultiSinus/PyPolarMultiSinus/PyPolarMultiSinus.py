from numpy import arange, sin, cos, pi
from pylab import figure, polar, show

t = arange(0, 2, 1./180)*pi
figure(1)
polar(t, sin(t))
figure(2)
polar(t, -sin(t))
figure(3)
polar(t, cos(t))
figure(4)
polar(t, -cos(t))
show()

