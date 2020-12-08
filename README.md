# Brickwork
Brickwork solves the problem where we need to lay down a second layer of bricks on top of a given layer.The first layer must be of size NxM where N and M even bigger than 0 and lesser than 100 and must contain bricks of size 1x2 or 2x1 (btw it works for 1x1).In case of invalid input the program throws an exception.The second layer must be created in a way that no bricks in it lies on a brick from the first layer.

## Input
On the first line N and M separated by a space must be inputted.

On the next N lines M numbers separated by a space must be inputted representing the bricks.

## Output
The new layer will be described in N lines with M numbers in each.

If the "fancybricks" in "config.cs" is true each brick will be surrounded by "*".

## Solution
The board is split into 2x2 squares.If a square contains a "horizontal" brick its replaced with a square containing 2 "vertical" brick.If not its replaced with a square containing 2 "horizontal".
