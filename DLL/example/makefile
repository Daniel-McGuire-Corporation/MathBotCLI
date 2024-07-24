# Define variables
CC = g++
CFLAGS = -Wall -Wextra -O2
LIBNAME = MathBotCLI
LIBFILE = lib$(LIBNAME).a
DLLFILE = $(LIBNAME).dll
HEADER = MathBotCLI.h
DEMO_SOURCES = client.cpp
DEMO_OBJECTS = $(DEMO_SOURCES:.cpp=.o)

# Default target
all: demoApp

# Rule to compile the demo application
demoApp: $(DEMO_OBJECTS) $(LIBFILE)
	$(CC) -o $@ $(DEMO_OBJECTS) -L. -l$(LIBNAME)

# Rule to compile .cpp files into .o files
%.o: %.cpp $(HEADER)
	$(CC) $(CFLAGS) -c $< -o $@

# Clean up build files
clean:
	rm -f $(DEMO_OBJECTS) demoApp
