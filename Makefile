config := Release

################################################################################

srcs := $(wildcard src/*)
bins := bin/$(config)/netstandard2.0/Unitility.dll

################################################################################

.PHONY: build clean rebuild

build: $(bins)

clean:
	rm -rf bin

rebuild: clean build

$(bins): $(srcs) lib/UnityEngine.dll
	dotnet build -c $(config)
