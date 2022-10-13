from tkinter import *
from pytube import YouTube

root=Tk()
root.geometry('500x300')
root.resizable(0,0)
root.title("Загрузчик видео с YouTube")
Label(root,text='Загрузчик видео с YouTube',font='arial 20 bold').pack()
link=StringVar()
Label(root,text='Вставьте ссылку здесь:',font='arial 15 bold').place(x=120,y=60)
link_enter=Entry(root,width=60,textvariable=link).place(x=10,y=90)

def Downloader():
    url=YouTube(str(link.get()))
    video=url.streams.first()
    video.download()
    Label(root,text='Загружен',font='arial 15').place(x=180,y=210)

Button(root,text='Скачать',font='arial 15 bold',bg='pale violet red',padx=2,command=Downloader).place(x=180,y=150)
root.mainloop()
