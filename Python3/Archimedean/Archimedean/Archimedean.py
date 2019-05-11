from numpy import radians, linspace, cos, sin
from pylab import plot, show


a = .1

t = radians(linspace(0,360*3,1000))
r = t * a
x = r*cos(t)
y = r*sin(t)
plot(x,y)
show()