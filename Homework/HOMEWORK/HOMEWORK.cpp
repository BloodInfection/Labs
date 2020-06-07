
#include <stdafx.h>
#include <Windows.h>
#include <string>
#include <algorithm>
#include <float.h>
#include <vector> 
#include <commctrl.h>
#include <math.h>
#include <windowsx.h>
#include <string>
#include <stdio.h>
#include <vector>
#include <ctime>


#define QUALITY	100000



HANDLE hThread1; //управление потоками 
HANDLE hThread2;
HANDLE hThread4;
HANDLE hThread5;

COLORREF COLOR = RGB(255, 255, 255);

float size = 0.5; //начальный размер

float angle = 9.3; //360

COLORREF Color = RGB(0, 0, 0);

void NewColorBackground() {
	srand(time((unsigned)0));
	COLOR = RGB(rand() % 255, rand() % 255, rand() % 255);
}

void NewColorGraph() {
	srand(time((unsigned)0));
	Color = RGB(rand() % 255, rand() % 255, rand() % 255);
}





//POINT Data[QUALITY];

std::vector<POINT> Data(QUALITY);

int DeletedPoints = 0;
float maxY;
float maxX;

float T = 0;

DWORD WINAPI Thread2(LPVOID t) {			//функция для первого потока
	int pos = 0;

	for (pos = 0; pos < QUALITY; pos++)
	{
		T += 0.006;
		Data[pos].x = (60 * (2 + cos(T / 0.4 + ((T / 2) / 3.03) - ((T / 2) / 3.03)))) * cos(T) + 500;
		Data[pos].y = -(60 * (2 + cos(T / 0.4 + ((T / 2) / 3.03) - ((T / 2) / 3.03)))) * sin(T) + 500;
	}
	return 0;
}




DWORD WINAPI Thread1(LPVOID t) {  //функция ,выполняемая первым потоком 

	HDC hdc = GetDC((HWND)t);
	MoveToEx(hdc, 0, 500, NULL);
	LineTo(hdc, 1000, 500);
	MoveToEx(hdc, 500, 0, NULL);
	LineTo(hdc, 500, 1000);
	for (int i = -30; i < 30; i++) {
		MoveToEx(hdc, 490, 500 + (i * 60 * size), NULL);
		LineTo(hdc, 510, 500 + (i * 60 * size));
	}
	for (int i = -30; i < 30; i++) {
		MoveToEx(hdc, 500 + (i * 60 * size), 490, NULL);
		LineTo(hdc, 500 + (i * 60 * size), 510);
	}
	ReleaseDC((HWND)t, hdc);



	return 0;
}

DWORD WINAPI Thread4(LPVOID t) {
	HDC hdc = GetDC((HWND)t);
	for (int i = 0; i < (((QUALITY * 1) / angle) / 2); i++) {
		SetPixelV(hdc, Data[i].x * size - (500 * size) + 500, Data[i].y * size - (500 * size) + 500, Color);
		SetPixelV(hdc, Data[i].x * size - (500 * size) + 500, Data[i].y * size - (500 * size) + 501, Color);
		SetPixelV(hdc, Data[i].x * size - (500 * size) + 501, Data[i].y * size - (500 * size) + 501, Color);
		SetPixelV(hdc, Data[i].x * size - (500 * size) + 501, Data[i].y * size - (501 * size) + 500, Color);
	}
	return 0;
}



DWORD WINAPI Thread5(LPVOID t) {
	HDC hdc = GetDC((HWND)t);
	for (int i = ((QUALITY * 1) / angle) / 2; i < ((QUALITY * 1) / angle); i++) {
		SetPixelV(hdc, Data[i].x * size - (500 * size) + 500, Data[i].y * size - (500 * size) + 500, Color);
		SetPixelV(hdc, Data[i].x * size - (500 * size) + 500, Data[i].y * size - (500 * size) + 501, Color);
		SetPixelV(hdc, Data[i].x * size - (500 * size) + 501, Data[i].y * size - (500 * size) + 501, Color);
		SetPixelV(hdc, Data[i].x * size - (500 * size) + 501, Data[i].y * size - (501 * size) + 500, Color);
	}
	return 0;
}

void StartDrawing(HWND hWnd) {
	hThread1 = CreateThread(NULL, 0, Thread1, hWnd, 0, NULL);
	hThread4 = CreateThread(NULL, 0, Thread4, hWnd, 0, NULL);
	hThread5 = CreateThread(NULL, 0, Thread5, hWnd, 0, NULL);
}

void StopDrawing(HWND hWnd) {
	TerminateThread(hThread1, 0);
	TerminateThread(hThread4, 0);
	TerminateThread(hThread5, 0);
}





LRESULT CALLBACK WindowProcess(HWND hWindow,
	UINT uMessage,
	WPARAM wParameter,
	LPARAM lParameter)
{

	switch (uMessage) {
	case WM_CREATE:
	{
		hThread2 = CreateThread(NULL, 0, Thread2, hWindow, 0, NULL);

	}
	return 0;
	case WM_LBUTTONDOWN: {
		hThread1 = CreateThread(NULL, 0, Thread1, hWindow, 0, NULL);
	}

						 return 0;

	case WM_KEYDOWN:
	{
		switch (wParameter) {
		case VK_SHIFT: {
			StopDrawing(hWindow);
			RECT Window;
			HDC hdc = GetDC(hWindow);
			GetWindowRect(hWindow, &Window);
			NewColorBackground(); //новый цвет фона
			FillRect(hdc, &Window, CreateSolidBrush(COLOR));
			StartDrawing(hWindow);
		}
					   return 0;
		case VK_CAPITAL: {
			StopDrawing(hWindow);
			RECT Window;
			HDC hdc = GetDC(hWindow);
			GetWindowRect(hWindow, &Window);
			NewColorGraph(); //новый цвет графика
			FillRect(hdc, &Window, CreateSolidBrush(COLOR));
			StartDrawing(hWindow);
		}
						 return 0;
		case VK_UP: {
			StopDrawing(hWindow);
			size += 0.25; //увеличение размера
			RECT Window;
			HDC hdc = GetDC(hWindow);
			GetWindowRect(hWindow, &Window);
			FillRect(hdc, &Window, CreateSolidBrush(COLOR));
			StartDrawing(hWindow);
		}
					return 0;
		case VK_DOWN: {
			StopDrawing(hWindow);
			size -= 0.25;	//уменьшение размера 
			RECT Window;
			HDC hdc = GetDC(hWindow);
			GetWindowRect(hWindow, &Window);
			FillRect(hdc, &Window, CreateSolidBrush(COLOR));
			StartDrawing(hWindow);
		}
					  return 0;
		case VK_LEFT: {
			StopDrawing(hWindow);
			angle += 0.2;        //увеличение угла
			RECT Window;
			HDC hdc = GetDC(hWindow);
			GetWindowRect(hWindow, &Window);
			FillRect(hdc, &Window, CreateSolidBrush(COLOR));
			StartDrawing(hWindow);
		}
					  return 0;
		case VK_RIGHT: {
			StopDrawing(hWindow);
			angle -= 0.2; //уменьшение угла
			RECT Window;
			HDC hdc = GetDC(hWindow);
			GetWindowRect(hWindow, &Window);
			FillRect(hdc, &Window, CreateSolidBrush(COLOR));
			StartDrawing(hWindow);
		}
					   return 0;
		}
	}
	return 0;
	case WM_DESTROY:
		//StopDrawing(hWindow);
		PostQuitMessage(0);
		return 0;
	default:
		return DefWindowProc(hWindow, uMessage, wParameter, lParameter);
	}
	return NULL;
}




int CALLBACK wWinMain(HINSTANCE hInstance, HINSTANCE, PWSTR szCmdLine, int nCmdShow) {
	MSG msg{};
	HWND hwnd{};
	WNDCLASSEX wc{ sizeof(WNDCLASSEX) };

	wc.cbClsExtra = 0;
	wc.cbWndExtra = 0;
	wc.hbrBackground = CreateSolidBrush(RGB(125, 125, 125)); //изначальный цвет окна 
	wc.hCursor = LoadCursor(nullptr, IDC_ARROW);
	wc.hIcon = LoadIcon(nullptr, IDI_APPLICATION);
	wc.hInstance = hInstance;

	wc.lpfnWndProc = WindowProcess;
	wc.lpszClassName = L"Class";
	wc.lpszMenuName = NULL;
	wc.style = CS_VREDRAW | CS_HREDRAW;
	if (!RegisterClassEx(&wc)) {
		return EXIT_FAILURE;
	}
	hwnd = CreateWindow(wc.lpszClassName, L"HOMEWORK",
		WS_OVERLAPPED | WS_CAPTION | WS_SYSMENU | WS_MINIMIZEBOX | WS_MAXIMIZEBOX /*запрет на изменение размера окна*/
		, 0, 0, 1000, 1000, NULL, NULL, wc.hInstance, NULL);
	if (hwnd == INVALID_HANDLE_VALUE)
	{
		return EXIT_FAILURE;
	}
	ShowWindow(hwnd, nCmdShow);
	UpdateWindow(hwnd);

	while (GetMessage(&msg, nullptr, 0, 0)) {
		DispatchMessage(&msg);
		TranslateMessage(&msg);
	}
	return static_cast<int>(msg.wParam);
}

