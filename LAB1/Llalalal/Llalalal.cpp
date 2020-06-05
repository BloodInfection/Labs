#include "stdafx.h"
#include <iostream>


#define MAX_LOADSTRING 100 
#include <string>
#include <Windows.h>

struct Planet
{

	COLORREF Color;
	int Offset;
	LPCWSTR Name;
	int Size;
	int TextSize;
	



};

Planet Planets[9];
int counter = 0;

LRESULT CALLBACK WndProc(HWND hWnd, UINT uMsg, WPARAM wParam, LPARAM lParam)
{
	HBRUSH turquoise = CreateSolidBrush(RGB(25, 25, 112)); //для закраски окна
	PAINTSTRUCT ps; // для рисования 
	HDC hdc; //для рисования описание для рисования 
	RECT rectplace; //для рисования  место куда рисовать 
	rectplace.top = 0;
	rectplace.bottom = 20;
	RECT ActualSize;
	GetClientRect(hWnd, &ActualSize);
	bool ispainted = false;
	switch (uMsg)
	{
	case WM_MOUSEHOVER:{}

	case WM_PAINT: //отрисовка планет
	{
		//if (ispainted == false) {




		//	for (int i = 0; i < 9; i++) {

		//		HBRUSH color = CreateSolidBrush(Planets[i].Color);
		//		hdc = GetDC(hWnd);
		//		SelectObject(hdc, color); //передача цвета кисти
		//		RECT ActualSize;
		//		GetClientRect(hWnd, &ActualSize); //зависимость от окна
		//		Ellipse(hdc,
		//			((ActualSize.right + Planets[i].Offset) / 2 - Planets[i].Size), //100 - размер 
		//			(ActualSize.bottom / 2 - Planets[i].Size),
		//			((ActualSize.right + Planets[i].Offset) / 2 + Planets[i].Size),
		//			(ActualSize.bottom / 2 + Planets[i].Size));
		//	}
		//	ispainted = true;
		//}
		hdc = BeginPaint(hWnd, &ps);
		SetBkMode(hdc, TRANSPARENT);
		HBRUSH color = CreateSolidBrush(Planets[counter].Color);
		SelectObject(hdc, color); //передача цвета кисти
		 //зависимость от окна
		if (counter > 0) {
			/*Arc(hdc, Planets[counter].x1, Planets[counter].y1, Planets[counter].x2, Planets[counter].y2, 10, 10, 10, 10); *///орбита 
		}
		SetTextColor(hdc, RGB(255, 255, 255));
		SetBkColor(hdc, RGB(25, 25, 112));
		TextOut(hdc, (ActualSize.right + Planets[counter].Offset) / 2 - Planets[counter].Size, (ActualSize.bottom / 2 + Planets[counter].Size), Planets[counter].Name, Planets[counter].TextSize);


		
		
		Ellipse(hdc,
			((ActualSize.right + Planets[counter].Offset) / 2 - Planets[counter].Size), //100 - размер 
			(ActualSize.bottom / 2 - Planets[counter].Size),
			((ActualSize.right + Planets[counter].Offset) / 2 + Planets[counter].Size),
			(ActualSize.bottom / 2 + Planets[counter].Size));


		
		EndPaint(hWnd, &ps);
		

	}
	break;
	case WM_MOUSEMOVE:
	{


	}
	break;


	case WM_LBUTTONDOWN:
	{
		hdc = GetDC(hWnd);
		RECT rectangle;
		GetClientRect(hWnd, &rectangle);
		FillRect(hdc, &rectangle, turquoise);
		ReleaseDC(hWnd, hdc);
		counter = -1;
		
	}
	break;
	case WM_RBUTTONDOWN:
	{	
		
		
			//HBRUSH color = CreateSolidBrush(Planets[counter].Color);
			//hdc = GetDC(hWnd);
			//SelectObject(hdc, color); //передача цвета кисти
			//RECT ActualSize;
			//GetClientRect(hWnd, &ActualSize); //зависимость от окна
			//Ellipse(hdc,
			//	((ActualSize.right + Planets[counter].Offset) / 2 - Planets[counter].Size), //100 - размер 
			//	(ActualSize.bottom / 2 - Planets[counter].Size),
			//	((ActualSize.right + Planets[counter].Offset) / 2 + Planets[counter].Size),
			//	(ActualSize.bottom / 2 + Planets[counter].Size));
			//ReleaseDC(hWnd, hdc);
		if (counter < 9){
			
			counter++;
			InvalidateRect(hWnd, &ActualSize, false);
		}
		
		
		
	}
	break;
	case WM_DESTROY:

		PostQuitMessage(0);
		break;
	default:
		return DefWindowProc(hWnd, uMsg, wParam, lParam);
	}
	return 0;
}

// Оконная функция вызывается операционной системой
// и получает сообщения из очереди для данного приложения
 // HINSTANCE hInstance Дескриптор текущего приложения.  PWSTR szCmdLine -КС. nt nCmdShow - режим отображения окна
int CALLBACK wWinMain(HINSTANCE hInstance, HINSTANCE, PWSTR szCmdLine, int nCmdShow) {
	MSG msg{}; // Структура для хранения сообщения 
	HWND hwnd{}; // Дескриптор главного окна программы (хранение)
	WNDCLASSEX wc{ sizeof(WNDCLASSEX) }; // Класс окна
	HBRUSH turquoise = CreateSolidBrush(RGB(25, 25, 112)); //Функция CreateSolidBrush создает логическую кисть, которая имеет заданный сплошной тон. Фон

//	wc — структура, содержащая информацию по настройке окна.
	Planets[0].Size = 50;
	Planets[0].Color = RGB(255, 225, 0);
	Planets[0].Name = L"Sun";
	Planets[0].Offset = 0;
	Planets[0].TextSize = 3;
	

	Planets[1].Size = 12;
	Planets[1].Color = RGB(128, 128, 128);
	Planets[1].Name = L"Mercury";
	Planets[1].Offset = 150;
	Planets[1].TextSize = 7;

	Planets[2].Size = 20;
	Planets[2].Color = RGB(128, 0, 0);
	Planets[2].Name = L"Venus";
	Planets[2].Offset = -200;
	Planets[2].TextSize = 5;

	Planets[3].Size = 19;
	Planets[3].Color = RGB(0, 128, 128);
	Planets[3].Name = L"Earth";
	Planets[3].Offset = 300;
	Planets[3].TextSize = 5;

	Planets[4].Size = 10;
	Planets[4].Color = RGB(255, 0, 0);
	Planets[4].Name = L"Mars";
	Planets[4].Offset = -350;
	Planets[4].TextSize = 4;

	Planets[5].Size = 30;
	Planets[5].Color = RGB(255, 160, 122);
	Planets[5].Name = L"Jupiter";
	Planets[5].Offset = 500;
	Planets[5].TextSize = 7;

	Planets[6].Size = 25;
	Planets[6].Color = RGB(255, 228, 181);
	Planets[6].Name = L"Saturn";
	Planets[6].Offset = -550;
	Planets[6].TextSize = 6;

	Planets[7].Size = 17;
	Planets[7].Color = RGB(0, 191, 255);
	Planets[7].Name = L"Uranus";
	Planets[7].Offset = 700;
	Planets[7].TextSize = 6;

	Planets[8].Size = 17;
	Planets[8].Color = RGB(0, 0, 255);
	Planets[8].Name = L"Neptune";
	Planets[8].Offset = -750;
	Planets[8].TextSize = 7;

	wc.cbClsExtra = 0; // Нет дополнительных данных класса 
	wc.cbWndExtra = 0; // Нет дополнительных данных окна 
	wc.hbrBackground = turquoise; 	// Заполнение окна цветом "turquoise" 
	wc.hCursor = LoadCursor(nullptr, IDC_ARROW); // Стандартный курсор 
	wc.hIcon = LoadIcon(nullptr, IDI_APPLICATION); // обычная иконка приложения
	wc.hInstance = hInstance;  // Дескриптор текущего приложения

	wc.lpszClassName = L"Class"; // Имя класса окна 
	wc.lpszMenuName = NULL; // Нет меню 
	wc.style = CS_VREDRAW | CS_HREDRAW; // Стиль окна (дефолт)

	wc.lpfnWndProc = WndProc;



	//// Регистрация класса окна

	if (!RegisterClassEx(&wc)) {
		return EXIT_FAILURE;
	}
	// Создание окна 
	hwnd = CreateWindow(wc.lpszClassName, L"Solar system", WS_OVERLAPPEDWINDOW, 0, 0, 1000, 1000, NULL, NULL, wc.hInstance, NULL); // Имя класса окна 
	if (hwnd == INVALID_HANDLE_VALUE)
	{
		return EXIT_FAILURE;
	}
	ShowWindow(hwnd, nCmdShow); // Показать окно
	UpdateWindow(hwnd);

	while (GetMessage(&msg, nullptr, 0, 0)) { // Цикл обработки сообщений 
		DispatchMessage(&msg); // Посылает сообщение функции WndProc() 
	}
	return static_cast<int>(msg.wParam);
}