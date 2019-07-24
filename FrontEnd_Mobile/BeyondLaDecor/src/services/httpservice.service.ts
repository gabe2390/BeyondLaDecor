import axios from 'axios';
import Axios from 'axios';
export const domain : string = "http://localhost:58237";
  export async function getEvents(){
    await Axios.get(`${domain}/Packages`, {
      params: {
        ID: 12345
      }
    .then(()=>{})
    .catch(()=>{});
  } 
