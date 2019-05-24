from numpy import linspace, pi, cos, sin
from pylab import plot, show

x = linspace(-pi, pi, 256, endpoint=True)

s = sin(x)
c = cos(x)

plot(x, s, color = "green")
plot(x, c, color = "yellow")

show()
