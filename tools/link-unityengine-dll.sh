#!/bin/sh
ln -s \
	$(locate UnityEngine.dll | grep '/Editor/Data/Managed/UnityEngine.dll$') \
	lib/
