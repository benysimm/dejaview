import allhomes
import googlesearch
import re
import mapping

def scrapetheworld(address, addressId):
    #get the url for allhomes from a google search rather than using the allhomes search
    addressurl = googlesearch.allHomesSalesUrl(address)
    if addressurl is not None:

        #urlParts = re.split('/', addressurl)
        #addressId = urlParts[len(urlParts) - 2] # get the address part including - to use for id '20-haines-street-curtin-canberra'

        data = allhomes.scrapeAddress(addressurl, addressId)
        #researchUrl = googlesearch.allHomesResearchUrl(address)
        data = data + "<br>"
        #data = data + allhomes.scrapeResearch(researchUrl, addressId)

        mapping.getImagery(addressId)
    else:
        data = "Address was unable to be found on allhomes"
    return data
