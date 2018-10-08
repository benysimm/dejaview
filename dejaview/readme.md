Welcome to the dejaview project.


# Overview

TODO


# Installation

1. Install python3. Install package dependencies with pip3, listed down below.
2. Run the python backend in dejaview-backend/dejaview-scrappers `python3 webapp.py`
3. You can now browse to `http://localhost:8080/scrape`
4. Install .NET core as per [official instructions](https://www.microsoft.com/net/learn/get-started/linuxredhat)
5. Run the .NET core dejaview REST API, in dejaview-backend/dejaview-api by running `dotnet run`
6. You can now browse the REST API `http://localhost:5000`. For example to pull back assets for an address try `http://localhost:5000/api/assets/100-outtrim-avenue-calwell-act-2905` (it wlil return empty if no scrapped assets exist for that address).
7. Finally time to install the frontend.
8. Install nodejs and the [yarn](https://yarnpkg.com/en/) package manager.
9. In a terminal head into the dejaview-frontend directory, and run `yarn install`. Wait a few minutes while the entire interwebs is downloaded...lots of npm modules needed, such as react and webpack.
10. Then run `yarn run start`.
11. You can now browse the frontend at `http://localhost:3000` for example [http://localhost:3000/address.html?address=100-outtrim-avenue-calwell-act-2905](http://localhost:3000/address.html?address=100-outtrim-avenue-calwell-act-2905)



# Solution Structure

## Frontend

A react and bulma based web frontend.


## Backend

A mashup of .NET core and Python backend services.


### dejaview-api

.NET core webapi based REST API.


### dejaview-scrapers

Python 3 scraping engine.



# Python Dependencies

Make sure these are installed, prior to lauching `webapp.py`

    asn1crypto (0.23.0)
    Beaker (1.5.4)
    beautifulsoup4 (4.6.0)
    bingmaps (0.3.7)
    blivet (2.1.11)
    blivet-gui (2.1.7)
    bottle (0.12.13)
    Brlapi (0.6.6)
    cffi (1.10.0)
    chardet (3.0.4)
    coverage (4.4.2)
    cryptography (2.0.2)
    cupshelpers (1.0)
    decorator (4.0.11)
    fros (1.1)
    googlemaps (2.5.1)
    gpg (1.9.0)
    humanize (0.5.1)
    idna (2.5)
    iniparse (0.4)
    IPy (0.81)
    isc (2.0)
    langtable (0.0.38)
    Mako (1.0.6.dev0)
    MarkupSafe (0.23)
    marshmallow (2.6.0)
    ntplib (0.3.3)
    olefile (0.44)
    ordered-set (2.0.0)
    pid (2.1.1)
    Pillow (4.3.0)
    pip (9.0.1)
    ply (3.9)
    pwquality (1.4.0)
    pycairo (1.15.3)
    pycparser (2.14)
    pycups (1.9.72)
    pycurl (7.43.0)
    pydbus (0.6.0)
    pyenchant (1.6.10)
    pygobject (3.26.1)
    pyGoogleSearch (2.5)
    pyinotify (0.9.6)
    PyIscsi (1.0)
    pykickstart (2.41)
    pyOpenSSL (17.2.0)
    pyparsing (2.1.10)
    pyparted (3.11.0)
    PySocks (1.6.7)
    python-augeas (0.5.0)
    python-dmidecode (3.12.2)
    python-meh (0.43)
    pytoml (0.1.14)
    pytz (2017.2)
    pyudev (0.21.0)
    pyxdg (0.25)
    PyYAML (3.12)
    registries (0.1)
    requests (2.9.1)
    requests-file (1.4)
    requests-ftp (0.3.1)
    rpm (4.14.0)
    sepolicy (1.1)
    setools (4.1.1)
    setroubleshoot (1.1)
    setuptools (37.0.0)
    simpleline (0.6)
    six (1.11.0)
    slip (0.6.4)
    slip.dbus (0.6.4)
    sos (3.5)
    SSSDConfig (1.16.0)
    systemd-python (234)
    urllib3 (1.22)
    wrapt (1.10.10)
    xmltodict (0.10.1)


# Storage

In the prototype no database is used. The file system under the `dejaview-frontend/images` directory is used like so:

    .
    └── 100-outtrim-avenue-calwell-act
        ├── AllHomes
        │   ├── 0017dd3142b3c78ff52bcf906ebcb044_hd.jpg
        │   ├── 08bb48a6a310284fabd931d0a08b2c36_hd.jpg
        │   ├── 09442b69888f99f5f6338093a1993c2c_hd.jpg
        │   ├── 1bac7f4cdb51a6042d721fff196344d6_hd.jpg
        │   ├── 21534504d0ad151d5c36f6163392a14a_hd.jpg
        │   ├── 230fb3a43fcfd14e6b008d480254129e_hd.jpg
        │   ├── 252c608b322828d0e99e1b9a019724bf_hd.jpg
        │   ├── 31cf50e104035c7202aac3dfda100f20_hd.jpg
        │   ├── 330ed15040ae307218b13b63e0cf107f_hd.jpg
        │   ├── 38f09b61c604e6e86b845e071e02bf49_hd.jpg
        │   ├── 3e4cb4b6f416259aa685cfbd9fb00daa_hd.jpg
        │   ├── 3ec0f32c2a75ff517ca981cb01f020ea_hd.jpg
        │   ├── 41f958c3ee36c152ce4206feb50827b6_hd.jpg
        │   ├── 50b8ea2eb7436750bb0a63ba996fef6e_hd.jpg
        │   ├── 51a6ba13fc5ea48289889d0bf199dd05_hd.jpg
        │   ├── 5b6895dded7d12714b3318cbb51d9cf1_hd.jpg
        │   ├── 5eceb7d20594ee38290b4685b547e25e_hd.jpg
        │   ├── 8029fc8376f5184211125e97651dd986_hd.jpg
        │   ├── 8eb13d6f4a23f13078125719c9299e09_hd.jpg
        │   ├── 962d6a4201438f703eb5f6f00c30fdb6_hd.jpg
        │   ├── 9b9315c980a6f57e046ad25d4968c92b_hd.jpg
        │   ├── 9d6f656b217d40a26baaee7a34922757_hd.jpg
        │   ├── 9fded9ab8858f63e19d9de4e477f4a3e_hd.jpg
        │   ├── a7e6aa99e715473776de47063fc89b02_hd.jpg
        │   ├── aa4ba2ca688157d9c0aee924e6b8615b_hd.jpg
        │   ├── baade93fef8b3f2dd33e2d37153c66d3_hd.jpg
        │   ├── c09e5e6612b23a717250722a8e941066_hd.jpg
        │   ├── c49677857ac5c09646f110ca250847e7_hd.jpg
        │   ├── d5e075d87bae35295423ad59cc4fc193_hd.jpg
        │   ├── d5e24073448758c3bee8a719f4e640f5_hd.jpg
        │   ├── d8d93c09112bef3260ea25e661abb685_hd.jpg
        │   ├── d98a6bea4e432ee58ce9b105778d0559_hd.jpg
        │   ├── ddb4aa5fdbdb9452d35ac6001c5e1d60_hd.jpg
        │   ├── de9f791e0e843da06601c8ac505e5a2e_hd.jpg
        │   ├── f1b0163715dd5bebcd4124405203197b_hd.jpg
        │   ├── f6a9f27b5f6ce0e308a8bf473b2ef06c_hd.jpg
        │   ├── fcbcfe29871b354214578bcf31b0ab33_hd.jpg
        │   └── ffb7932f0e03ffbcd3954f10b28d1fe4_hd.jpg
        ├── Bing
        │   ├── bingAreaImagery.jpg
        │   ├── bingLocalRoadMap.jpg
        │   └── bingTargetSatellite.jpg
        └── Google
            ├── googleAreaImagery.jpg
            ├── googleLocalRoadMap.jpg
            ├── googleStreetView.jpg
            ├── googleSuburbRoadMap.jpg
            └── googleTargetSatellite.jpg


Go Team!
