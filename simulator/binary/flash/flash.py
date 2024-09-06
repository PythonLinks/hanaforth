
with open ("../../build/iceimage.hex") as source:
     lines = source.readlines()

with open("flash.hex", mode='w') as file:
   for line in lines:
        file.write(line[:2])
        file.write ("\n")
        file.write(line[2:])
