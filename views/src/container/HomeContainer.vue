<template>
    <div>
        <the-header></the-header>
        <the-content />
        <the-footer></the-footer>
    </div>
</template>

<script>
import TheHeader from '../components/TheHeader'
import TheFooter from '../components/TheFooter'
import TheContent from '../admin/components/TheContent.vue'
export default {
    components:{
        TheHeader,
        TheFooter,
        TheContent
    }
}
</script>

<style>

</style>