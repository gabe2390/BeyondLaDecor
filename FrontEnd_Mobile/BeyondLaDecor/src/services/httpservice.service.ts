import axios, { AxiosResponse } from 'axios';
import { EventType } from '../models/event-type.model';
import { Package } from '../models/package.model';
import { Product } from '../models/product.model';
import { Service } from '../models/service.model';

const domain: string = "http://192.168.1.228:58237";

function getEvents(): Promise<AxiosResponse<Event[]>> {
  return axios.get(`${domain}/Events`);
}
function getPackages(): Promise<AxiosResponse<Package[]>> {
  return axios.get(`${domain}/Packages`);
}
function getEventTypes(): Promise<AxiosResponse<EventType[]>> {
  return axios.get(`${domain}/EventTypes`);
}
function getProducts(): Promise<AxiosResponse<Product[]>> {
  return axios.get(`${domain}/Products`);
}
function getServices(): Promise<AxiosResponse<Service[]>> {
  return axios.get(`${domain}/Services`);
}
function getEventCreationDetails(): Promise<any> {
  return axios.all<any>([getEventTypes(), getPackages(), getServices(), getProducts()]);
}
export let HttpService = {
  getEvents: getEvents,
  getPackages: getPackages,
  getEventCreationDetails: getEventCreationDetails
}