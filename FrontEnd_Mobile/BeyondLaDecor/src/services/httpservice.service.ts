import Axios, { AxiosResponse } from 'axios';
export const domain: string = "http://localhost:58237";
 async function getEvents() : Promise<AxiosResponse<Event[]>>  {
  return await Axios.get(`${domain}/Events`, {});
} 
async function getPackages() : Promise<AxiosResponse<Event[]>>  {
  return await Axios.get(`${domain}/Packages`, {});
} 
export let HttpService = {
  getEvents : getEvents,
  getPackages : getPackages
}