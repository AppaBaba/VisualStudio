# Python 3.7.4 program for plotting
# Works with Anconda3 (5.2.0) using VS Python Suport
# Source code can be used in Spyder also

from numpy import linspace, pi, cos, sin
from pylab import plot, show

x = linspace(-pi, pi, 256, endpoint=True)

s = sin(x)
c = cos(x)

plot(x, s, color = "green",)
plot(x, c, color = "yellow")

show()
