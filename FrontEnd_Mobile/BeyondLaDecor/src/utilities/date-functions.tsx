export let today = new Date();
export let thisYear = today.getFullYear();
export let thisMonth = today.getMonth() + 1;
export let thisDate = today.getDate();
export let oneYearAgo = new Date(thisYear - 1, thisMonth, thisDate);
export let threeYearsAgo = new Date(thisYear - 3, thisMonth, thisDate);
export let oneMonthAgo = new Date(thisYear, thisMonth - 1, thisDate);
export let threeMonthsAgo = new Date(thisYear, thisMonth - 3, thisDate);
export let sixMonthsAgo = new Date(thisYear, thisMonth - 6, thisDate);
export let monthsFrom = (months: number) => new Date(thisYear, thisMonth + months, thisDate);
export let DateHelper = {
    oneYearAgo: oneYearAgo,
    threeYearsAgo: threeYearsAgo,
    oneMonthAgo: oneMonthAgo,
    threeMonthsAgo: threeMonthsAgo,
    sixMonthsAgo: sixMonthsAgo,
    monthsFrom: monthsFrom
}