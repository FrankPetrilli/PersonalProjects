#!/usr/bin/python

import os
import time
import dbus
session_bus = dbus.SessionBus()
from gi.repository import TelepathyGLib as Tp
from gi.repository import GObject
loop = GObject.MainLoop()
am = Tp.AccountManager.dup()
am.prepare_async(None, lambda *args: loop.quit(), None)
loop.run()

screensaver_started = 0
running = 0

while 1:
 active = 0
 out = ""
 pid = 0

 if screensaver_started == 0:
     # Don't do anything if the screensaver isn't running
     s = os.popen("pidof gnome-screensaver")
     spid = s.read()
     s.close()
     if len(spid) > 0:
         screensaver_started = 1
 else:
     h = os.popen("gnome-screensaver-command -q", "r")
     out = h.read()
     active = out.find("inactive")
     h.close()

     if active < 0 and running == 0:
         am.set_all_requested_presences(Tp.ConnectionPresenceType.AWAY, 'away', "")
         running = 1
     elif active > 0 and running == 1:
         am.set_all_requested_presences(Tp.ConnectionPresenceType.AVAILABLE, 'available', "")
         running = 0
     time.sleep(3)
