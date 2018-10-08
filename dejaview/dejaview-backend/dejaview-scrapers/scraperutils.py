import urllib.request
import os
import datetime
import re

def downloadImage(addressId, fileSource, fileUrl, fileName):
    #myPath = os.path.join(
    #    "C:" + os.sep + "3.Development" + os.sep + "Python" + os.sep + "dejaview" + os.sep + "images")
    #fullfilename = os.path.join(rootAddressPath(addressId, fileSource), filename)
    urllib.request.urlretrieve(fileUrl, fullFileName(addressId,fileSource,fileName))

def generateFileName(addressId, filesource, counter):
    #currentDateTime = datetime.datetime.now().strftime("%Y-%m-%d-%H-%M-%S")
    return str(addressId) + "_" + filesource + "_image_" + str(counter) + ".jpg"

def urlFileName(url):
    parts = re.split('/', url)
    return parts[len(parts) - 1]

def fullFileName(addressId,fileSource,fileName):
    return os.path.join(rootAddressPath(addressId, fileSource), fileName)

#[Git Repository Path]/Data
def dataRoot():
    return os.path.normpath(os.path.abspath(os.path.curdir) + os.sep + os.pardir + os.sep + os.pardir + os.sep + "Data")
    # return "/home/ben/git/dejaview/dejaview-frontend/images/";

#[dataRoot]/ID/FileSource : Makes dirs if required
def rootAddressPath(addressId, fileSource):
    addressPath = os.path.join(dataRoot(),addressId,fileSource)
    os.makedirs(addressPath,0o777,True)
    return addressPath
