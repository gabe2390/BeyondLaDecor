import axios, { AxiosResponse } from 'axios';
const domain: string = "http://localhost:58237";
function getEvents(): Promise<AxiosResponse<Event[]>> {
  return axios.get(`${domain}/Events`);
}
 function getPackages(): Promise<AxiosResponse<Event[]>> {
  return  axios.get(`${domain}/Packages`);
}
export let HttpService = {
  getEvents: getEvents,
  getPackages: getPackages
}