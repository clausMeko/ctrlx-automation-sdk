02.07.2024

* Daniel Gabrikov (PraktikumL Angew. Inf.)
* Emrah Emre (Antriebstechnik)
* Aurel Wibawa (Applikationsteam)

## Architektur

* 5 Software
* 5 HW-Lösungen (z.b. CtrlxCore)
* Aber "IPC" hÄte mehr performance (wenn nötig)

      Apps: Motion, IOT ... 
          |
      Data LAYER
          |
      UBUNTU CORE

* e.g. PLC <--> Data Layer <--> Motion App

## WHY?

* mehrere apps also netzwerk (MQTT) app + Logik + ... 

## Build Task

* build upload task script im scripts folder
* VSCode "Build Tasks"
* debug --> Online
* ctrlx: `C:\Users\claus.bissinger\PycharmProjects\ctrlx-automation-sdk\samples-python\datalayer.remote.debug\debug.py`

## Logs

* Diagrnositcs > Logbook > History
* Developer view
* Filter

## Details

* Data Layer:
    * Im Browser nur darstellung
    * Aber auch als 'shared memory'/'MQ' zur programmierung verfügbar
    * asynchron bereitgestellt und v. ctrlx synchronisiert
* Achseinrichtung muss man in der Motionapp machen
* Ethercat master Geräte scannen

## PLC Engineering

* VS wie es marlene nutzt
* Echtzeitloops in PLC und dann Python steuert die task an
* über Symbolkonfiguration kann man plc variablne nach datalayer exportieren

## Fragen

* was ist gentry sync?

## IPC & HMI

* hmi server läuft auf der Core
* WEBIQ ~> Browser --> WR21 WebPanel (Smart HMI etc.
* Empfehlung: WEBIQ (kostet) für komplexe Projekte, Codesys(free) für einfache Prjekte
* ctrlx7 -> DP landing page
* https://store.boschrexroth.com/sun_categoryRedirect?category=cls_eCommerce_lx_1182027&locale=de_DE

## Other

* 3x/year release
* LTS 2.26

## Visual Inspection

* edge device performance i7 ggf. ok??


