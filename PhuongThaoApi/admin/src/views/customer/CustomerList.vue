<template>
    <div class="customer">
        <header-basic>Danh sách khách hàng</header-basic>
        <div class="customer-header-function">
            <input-search />
            <button-refresh />
        </div>
        <div class="customer-table">
            <grid-table />
        </div>
    </div>
</template>
<script>
import HeaderBasic from '../../components/basic/HeaderBasic.vue'
import ButtonRefresh from '../../components/basic/ButtonRefresh.vue'
import GridTable from '../../components/customer/GridTable.vue'
import InputSearch from '../../components/basic/InputSearch.vue'
export default {
  components: {
    GridTable,
    HeaderBasic,
    InputSearch,
    ButtonRefresh
  },
}
</script>

<style scoped>
.customer-header-function{
    display: flex;
    margin-top: 20px;
    justify-content: space-between;
}
</style>