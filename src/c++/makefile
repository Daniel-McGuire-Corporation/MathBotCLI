# Default compiler and flags
CXX = g++
CXXFLAGS = -std=c++17 -Wall -Wextra -O2

# Source files
SRCS = main.cpp usage.cpp

# Default target
all: linux

# Windows (MSVC) target
win32: CXX = cl
win32: TARGET = MathBotCLI.exe
win32: OBJS = $(SRCS:.cpp=.obj)
win32: CXXFLAGS = /EHsc /W4 /O2
win32: $(TARGET)

# macOS target (Clang)
mac: CXX = clang++
mac: TARGET = MathBotCLI
mac: OBJS = $(SRCS:.cpp=.o)
mac: CXXFLAGS = -std=c++17 -Wall -Wextra -O2 -target x86_64-apple-macos10.15
mac: $(TARGET)

# iOS target (Clang)
ios: CXX = clang++
ios: TARGET = MathBotCLI.ios
ios: OBJS = $(SRCS:.cpp=.o)
ios: CXXFLAGS = -std=c++17 -Wall -Wextra -O2 -arch arm64 -isysroot $(shell xcrun --sdk iphoneos --show-sdk-path)
ios: $(TARGET)

# Linux target (GCC)
linux: CXX = g++
linux: TARGET = MathBotCLI
linux: OBJS = $(SRCS:.cpp=.o)
linux: CXXFLAGS = -std=c++17 -Wall -Wextra -O2
linux: $(TARGET)

# Link the target
$(TARGET): $(OBJS)
	$(CXX) $(CXXFLAGS) -o $@ $^

# Compile source files to object files
%.o: %.cpp
	$(CXX) $(CXXFLAGS) -c -o $@ $<

# MSVC-specific object rule
%.obj: %.cpp
	$(CXX) $(CXXFLAGS) /c /Fo$@ $<

# Clean up build files
clean:
	rm -f MathBotCLI MathBotCLI.exe MathBotCLI.ios $(SRCS:.cpp=.o) $(SRCS:.cpp=.obj)

# Phony targets
.PHONY: all win32 mac ios linux clean