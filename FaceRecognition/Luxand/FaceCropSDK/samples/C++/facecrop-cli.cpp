// facecrop-cli.cpp : Defines the entry point for the console application.
//

#include <stdlib.h>
#include <stdio.h>
#include <string.h>
#include "LuxandFaceCrop.h"

void PrintUsage(char * myfilename)
{
	printf("Usage: facecrop <in_file> <out_file> --key <activation_key> [--size <width>x<height>] [--scale <float>] [--shift <-1.0..1.0> <-1.0..1.0>] [--jpeg_quality <0..100>] [--performance <0..2>] [--threshold <int>] [--coords]\n");
}

int main(int argc, char** argv)
{
	printf("FaceCrop CLI v 1.0 (c) 2005-2010 Luxand, Inc.\n\n");
	if (argc < 3){
        PrintUsage(argv[0]);
        exit(-1);
	}

    char * InputFileName = argv[1];
    char * OutFileName = argv[2];

	int width = 337;
	int height = 450;
	float scale = 1.0f;
	float shiftX = 0.0f;
	float shiftY = 0.0f;
	int jpegquality = 90;
	char * activation_key = (char *)NULL;
	FcDetectionPerformance level = fcPerformanceNormal;
	int tmp_level = 0;
	int threshold = 3;
	
	bool OnlyPrintCoords = false;
	bool HaveKey = false;
	for (int i=3; i<argc; i++){
		if (!strcmp((const char *)argv[i], "--key")){
			if (i+1 >= argc || !strlen(argv[i+1])){
				PrintUsage(argv[0]);
				exit(-2);
			} else {
				activation_key = argv[i+1];
				HaveKey = true;
				++i;
			}
		}
		else if (!strcmp((const char *)argv[i], "--size")){
			if (i+1 >= argc || sscanf(argv[i+1], "%dx%d", &width, &height) != 2){
				PrintUsage(argv[0]);
				exit(-3);
			} else {
				++i;
			}
		}
		else if (!strcmp((const char *)argv[i], "--scale")){
			if (i+1 >= argc || sscanf(argv[i+1], "%f", &scale) != 1){
				PrintUsage(argv[0]);
				exit(-4);
			} else {
				++i;
			}
		}
		else if (!strcmp((const char *)argv[i], "--shift")){
			if (i+1 >= argc || i+2 >= argc || sscanf(argv[i+1], "%f", &shiftX) != 1 || sscanf(argv[i+2], "%f", &shiftY) != 1){
				PrintUsage(argv[0]);
				exit(-5);
			} else {
				i+=2;
			}
		}
		else if (!strcmp((const char *)argv[i], "--jpeg_quality")){
			if (i+1 >= argc || sscanf(argv[i+1], "%d", &jpegquality) != 1){
				PrintUsage(argv[0]);
				exit(-6);
			} else {
				++i;
			}
		}
		else if (!strcmp((const char *)argv[i], "--performance")){
			if (i+1 >= argc || sscanf(argv[i+1], "%d", &tmp_level) != 1 || tmp_level <0 || tmp_level>2){
				PrintUsage(argv[0]);
				exit(-7);
			} else {
				level = (FcDetectionPerformance)tmp_level;
				++i;
			}
		}
		else if (!strcmp((const char *)argv[i], "--threshold")){
			if (i+1 >= argc || sscanf(argv[i+1], "%d", &threshold) != 1){
				PrintUsage(argv[0]);
				exit(-7);
			} else {
				++i;
			}
		}
		else if (!strcmp((const char *)argv[i], "--coords")){
			OnlyPrintCoords = true; 
		}
		else {
			fprintf(stderr, "unknown parameter %s\n", argv[i]);
			PrintUsage(argv[0]);
			exit(-8);
		}
	}

	if (!HaveKey){
		PrintUsage(argv[0]);
		exit(-9);
	}
	
	int result = fcActivate(activation_key);
	if (result){
		fprintf(stderr, "Error %d activating facecrop library.\n", result);
		exit(-10);
	}

	result = fcSetFaceScale(scale);
	if (result){
		fprintf(stderr, "Error %d setting scale.\n", result);
		exit(-11);
	}
	result = fcSetFaceShift(shiftX, shiftY);
	if (result){
		fprintf(stderr, "Error %d setting shift.\n", result);
		exit(-12);
	}
	result = fcSetJpegQuality(jpegquality);
	if (result){
		fprintf(stderr, "Error %d setting JPEG quality.\n", result);
		exit(-13);
	}
	result = fcSetDetectionPerformance(level);
	if (result){
		fprintf(stderr, "Error %d setting face detection performance level.\n", result);
		exit(-14);
	}
	result = fcSetDetectionThreshold(threshold);
	if (result){
		fprintf(stderr, "Error %d setting face detection threshold.\n", result);
		exit(-15);
	}
	
	

	if (OnlyPrintCoords){
		int x1 = 0;
		int y1 = 0;
		int x2 = 0;
		int y2 = 0;
		result = fcGetFacePosition(InputFileName, width, height, &x1, &y1, &x2, &y2);
		if (result){
			fprintf(stderr, "Error %d obtaining face position.\n", result);
			exit(-16);
		} else {
			printf("%d %d %d %d\n", x1, y1, x2, y2);
		}
	} else {
		result = fcFaceCrop(InputFileName, OutFileName, width, height);
		if (result){
			fprintf(stderr, "Error %d cropping face.\n", result);
			exit(-17);
		} 
	}

	return 0;
}
